using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlatformaEducationala.BusinessLogicLayer;

namespace PlatformaEducationala
{
    public partial class UpdateAsocProfesorMaterie : Form
    {
        public UpdateAsocProfesorMaterie()
        {
            InitializeComponent();
            ListMaterii();
            ListProfesori();
        }

        private void ListMaterii()
        {
            MaterieBL materiiBL = new MaterieBL();
            comboBoxMateriiAsocUp.DisplayMember = "nume_materie";
            comboBoxMateriiAsocUp.ValueMember = "id_materie";
            comboBoxMateriiAsocUp.DataSource = materiiBL.GetMaterii();
        }

        private void ListProfesori()
        {
            ProfesorBL profBL = new ProfesorBL();
            comboBoxProfiAsocUp.DisplayMember = "nume_profesor";
            comboBoxProfiAsocUp.ValueMember = "id_profesor";
            comboBoxProfiAsocUp.DataSource = profBL.GetProfesori();

            comboBoxUpdateAsocProf.DisplayMember = "nume_profesor";
            comboBoxUpdateAsocProf.ValueMember = "id_profesor";
            comboBoxUpdateAsocProf.DataSource = profBL.GetProfesori();

        }

        private void buttonUpdateMateriiPofesori_Click(object sender, EventArgs e)
        {
            ProfesorBL profBL = new ProfesorBL();
            MaterieBL  matBL = new MaterieBL();
            int materieID = int.Parse(comboBoxMateriiAsocUp.SelectedValue.ToString());
            int profesorID = int.Parse(comboBoxProfiAsocUp.SelectedValue.ToString());
            int profIDNew = int.Parse(comboBoxUpdateAsocProf.SelectedValue.ToString());
            DataTable id = profBL.GetIdForProfMaterie(materieID, profesorID);
            int prof_materieID = 0;
            bool ok = false;
            for (int i = 0; i < id.Rows.Count; i++)
            {
                if (id.Rows[i] != null)
                {
                    prof_materieID = int.Parse(id.Rows[i][id.Columns[0]].ToString());
                    ok = true;
                }
            }
            if (ok)
            {
                profBL.UpdateAsocProfesorMaterie(prof_materieID, profIDNew);
                labelMasUpdateAscoProfMaterie.Text = "Actualizarea a fost realizata cu succes!";
            }
            else
                labelMasUpdateAscoProfMaterie.Text = "Actualizare esuata. Asocierea initiala nu exista!";


        }

        private void buttonCancelAsocUpMateriiProfesori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAsocProfesorMaterie_Load(object sender, EventArgs e)
        {

        }

       
    }
}
