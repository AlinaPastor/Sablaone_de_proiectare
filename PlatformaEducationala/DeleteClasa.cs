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
    public partial class DeleteClasa : Form
    {
        public DeleteClasa()
        {
            InitializeComponent();
            ListClasa();
        }


        private void ListClasa()
        {
            ClasaBL clasaBL = new ClasaBL();
            comboBoxDeleteClasa.DisplayMember = "nume_clasa";
            comboBoxDeleteClasa.ValueMember = "id_clasa";
            comboBoxDeleteClasa.DataSource = clasaBL.GetClase();
        }





        private void buttonDeleteProf_Click(object sender, EventArgs e)
        {

           
            

        }

        private void buttonCancelDeleteClasa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteClasa_Click(object sender, EventArgs e)
        {
            int clasaID = int.Parse(comboBoxDeleteClasa.SelectedValue.ToString());
            if (MessageBox.Show("Sigur vreti sa stergeti clasa?", "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClasaBL clasaBL = new ClasaBL();
                clasaBL.DeleteClasa(clasaID);
                labelDeleteClasa.Text = "Stergerea a fost realizata cu succes! ";

            }
            ListClasa();
        }
    }
}
