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
    public partial class AddProfesor : Form
    {
        public AddProfesor()
        {
            InitializeComponent();
        }

        private void ButtonAddProf_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeProf.Text;
            string prenume = textBoxPrenumeProf.Text;
            string user = textBoxUserProf.Text;
            string parola = textBoxParolaProf.Text;
            ProfesorBL profesorBL = new ProfesorBL();
            if (!string.IsNullOrWhiteSpace(nume) && !string.IsNullOrWhiteSpace(prenume) && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(parola))
            {
                profesorBL.AddProfesor(nume, prenume, user, parola);
                labelEroareProf.Text = "Adaugare cu succes! ";

                textBoxNumeProf.Text = "";
                textBoxPrenumeProf.Text = "";
                textBoxUserProf.Text = "";
                textBoxParolaProf.Text = "";
            }
            else
                labelEroareProf.Text = "Date incomplete ! ";

        }

        private void buttonCancelProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

   

    }
}
