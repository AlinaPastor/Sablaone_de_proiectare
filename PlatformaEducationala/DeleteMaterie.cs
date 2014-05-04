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
    public partial class DeleteMaterie : Form
    {
        public DeleteMaterie()
        {
            InitializeComponent();
            ListMaterii();
        }


        private void ListMaterii()
        {
            MaterieBL materieBL = new MaterieBL();
            comboBoxDeleteMaterii.DisplayMember = "nume_materie";
            comboBoxDeleteMaterii.ValueMember = "id_materie";
            comboBoxDeleteMaterii.DataSource = materieBL.GetMaterii();

        }

        private void buttonDeleteMaterie_Click(object sender, EventArgs e)
        {


            int materieID = int.Parse(comboBoxDeleteMaterii.SelectedValue.ToString());
            if (MessageBox.Show("Sigur vreti sa stergeti clasa?", "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MaterieBL materieBL = new MaterieBL();
                materieBL.DeleteMaterie(materieID);
                labelDeleteMaterii.Text = "Stergerea a fost realizata cu succes! ";

            }
            ListMaterii();

        } 

        private void buttonCancelDeleteMaterie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
