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
    public partial class AsocProfesorMaterie : Form
    {
        public AsocProfesorMaterie()
        {
            InitializeComponent();
            ListMaterii();
            ListProfesori();
        }

        private void ListMaterii()
        {
            MaterieBL materiiBL = new MaterieBL();
            comboBoxMateriiAsoc.DisplayMember = "nume_materie";
            comboBoxMateriiAsoc.ValueMember = "id_materie";
            comboBoxMateriiAsoc.DataSource = materiiBL.GetMaterii();
        }

        private void ListProfesori()
        {
            ProfesorBL profBL = new ProfesorBL();
            comboBoxProfiAsoc.DisplayMember = "nume_profesor";
            comboBoxProfiAsoc.ValueMember = "id_profesor";
            comboBoxProfiAsoc.DataSource = profBL.GetProfesori();
        }

        private void buttonAsociereMateriiPofesori_Click(object sender, EventArgs e)
        {
            int materieID = int.Parse(comboBoxMateriiAsoc.SelectedValue.ToString());
            int profID = int.Parse(comboBoxProfiAsoc.SelectedValue.ToString());
            ProfesorBL profBL = new ProfesorBL();
            profBL.AsocProfesorMaterie(profID, materieID);

        }

        private void buttonCancelAsocMateriiProfesori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
