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
    public partial class UpdateProfesor : Form
    {
        public UpdateProfesor()
        {
            InitializeComponent();
            ListProfesori();
        }

        private void PopulateUpdateControls()
        {
            int profesorID = int.Parse(comboBoxProfiUpdate.SelectedValue.ToString());
            ProfesorBL profesorBL = new ProfesorBL();
            DataSet ds = profesorBL.GetProfesoriById(profesorID);
            textBoxNumeProf.Text = ds.Tables[0].Rows[0]["nume_profesor"].ToString();
            textBoxPrenumeProf.Text = ds.Tables[0].Rows[0]["prenume_profesor"].ToString();
            textBoxUserProf.Text = ds.Tables[0].Rows[0]["user_profesor"].ToString();
            textBoxParolaProf.Text = ds.Tables[0].Rows[0]["parola_profesor"].ToString();
        }

        private void ListProfesori()
        {
            ProfesorBL profesorBL = new ProfesorBL();
            comboBoxProfiUpdate.DisplayMember = "nume_profesor";
            comboBoxProfiUpdate.ValueMember = "id_profesor";
            comboBoxProfiUpdate.DataSource = profesorBL.GetProfesori().Tables[0];
        }

        private void comboBoxProfiUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateUpdateControls();
        }

        private void ButtonUpdateProf_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeProf.Text;
            string prenume = textBoxPrenumeProf.Text;
            string user = textBoxUserProf.Text;
            string parola = textBoxParolaProf.Text;
            ProfesorBL profesorBL = new ProfesorBL();
            if (!string.IsNullOrWhiteSpace(nume) && !string.IsNullOrWhiteSpace(prenume) && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(parola))
            {
                int profesorID = int.Parse(comboBoxProfiUpdate.SelectedValue.ToString());
                profesorBL.UpdateProfesor(profesorID, nume, prenume, user, parola);
                labelEroareProf.Text = "Actualizarea a fost realizata cu succes! ";

             
            }
            else
                labelEroareProf.Text = "Date incomplete ! ";
            ListProfesori();
        }

        private void buttonCancelProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
