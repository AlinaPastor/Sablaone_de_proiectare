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
    public partial class UpdateAsocProfesorClasa : Form
    {
        public UpdateAsocProfesorClasa()
        {
            InitializeComponent();
            ListMaterii();
            ListProfesori();
            ListClasa();
        }

        private void ListMaterii()
        {
            MaterieBL materiiBL = new MaterieBL();
            comboBoxMateriiAsocPMCUp.DisplayMember = "nume_materie";
            comboBoxMateriiAsocPMCUp.ValueMember = "id_materie";
            comboBoxMateriiAsocPMCUp.DataSource = materiiBL.GetMaterii().Tables[0];
        }

        private void ListProfesori()
        {
            ProfesorBL profBL = new ProfesorBL();
            int id_materie = int.Parse(comboBoxMateriiAsocPMCUp.SelectedValue.ToString());
            
         
          
            comboBoxProfiAsocPMCUp.DisplayMember = "nume_profesor";
            comboBoxProfiAsocPMCUp.ValueMember = "id_profesor";
            comboBoxProfiAsocPMCUp.DataSource = profBL.GetProfesoriByMaterieId(id_materie).Tables[0];

            comboBoxProfiAsocPMCUpNew.DisplayMember = "nume_profesor";
            comboBoxProfiAsocPMCUpNew.ValueMember = "id_profesor";
            comboBoxProfiAsocPMCUpNew.DataSource = profBL.GetProfesoriByMaterieId(id_materie).Tables[0];
        }

        private void ListClasa()
        {
            ClasaBL clasaBL = new ClasaBL();
            comboBoxClaseAsocPMCUp.DisplayMember = "nume_clasa";
            comboBoxClaseAsocPMCUp.ValueMember = "id_clasa";
            comboBoxClaseAsocPMCUp.DataSource = clasaBL.GetClase().Tables[0];
        }

        private void buttonCancelAsocProfMatClasaUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAsocProfMatClasaUp_Click(object sender, EventArgs e)
        {
            //ProfesorBL profBL = new ProfesorBL();
            //MaterieBL matBL = new MaterieBL();
            ClasaBL clasaBL = new ClasaBL();
            int profesorID = int.Parse(comboBoxProfiAsocPMCUp.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxMateriiAsocPMCUp.SelectedValue.ToString());
            int clasaID = int.Parse(comboBoxClaseAsocPMCUp.SelectedValue.ToString());
            bool teza = bool.Parse(textBoxTezaAsocPMCUp.Text);

            int profIDNew = int.Parse(comboBoxProfiAsocPMCUpNew.SelectedValue.ToString());

            DataSet id = clasaBL.GetIdForProfMaterieClasaTeza(profesorID, materieID, clasaID, teza);

            int prof_clasaID = 0;
            bool ok = false;
            for (int i = 0; i < id.Tables[0].Rows.Count; i++)
            {
                if (id.Tables[0].Rows[i] != null)
                {
                    prof_clasaID = int.Parse(id.Tables[0].Rows[i][0].ToString());
                    ok = true;
                }
            }
            if (ok)
            {
                clasaBL.UpdateAsocProfesorClasa(prof_clasaID, profIDNew);
                labelMsgAsocPMCUp.Text = "Actualizarea a fost realizata cu succes!";
            }
            else
                labelMsgAsocPMCUp.Text = "Actualizare esuata. Asocierea initiala nu exista!";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMateriiAsocPMCUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProfiAsocPMCUp.DataSource = null;
            comboBoxProfiAsocPMCUpNew.DataSource = null;
            ListProfesori();
        }

        
    }
}
