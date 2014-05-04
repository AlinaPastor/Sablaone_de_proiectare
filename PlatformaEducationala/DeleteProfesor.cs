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
    public partial class DeleteProfesor : Form
    {
        public DeleteProfesor()
        {
            InitializeComponent();
            ListProfesori();
        }

        private void ListProfesori()
        {
            ProfesorBL profesorBL = new ProfesorBL();
            comboBoxDeleteProf.DisplayMember = "nume_profesor";
            comboBoxDeleteProf.ValueMember = "id_profesor";
            comboBoxDeleteProf.DataSource = profesorBL.GetProfesori();
        }

        private void buttonDeleteProf_Click(object sender, EventArgs e)
        {
            int profesorID = int.Parse(comboBoxDeleteProf.SelectedValue.ToString());
            if (MessageBox.Show("Sigur vreti sa stergeti profesorul?", "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProfesorBL profesorBL = new ProfesorBL();
                profesorBL.DeleteProfesor(profesorID);
                labelDeleteProf.Text = "Stergerea a fost realizata cu succes! ";

            }
            ListProfesori();
        }

        private void buttonCancelUpdateProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
