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
    public partial class DeleteElev : Form
    {
        public DeleteElev()
        {
            InitializeComponent();
            ListElevi();
        }

        private void ListElevi()
        {
            ElevBL elevBL = new ElevBL();
            comboBoxDeleteElev.DisplayMember = "nume_elev";
            comboBoxDeleteElev.ValueMember = "id_elev";
            comboBoxDeleteElev.DataSource = elevBL.GetElevi();
        }





        private void buttonDeleteProf_Click(object sender, EventArgs e)
        {

            int elevID = int.Parse(comboBoxDeleteElev.SelectedValue.ToString());
            if (MessageBox.Show("Sigur vreti sa stergeti elevul?", "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ElevBL elevBL = new ElevBL();
                elevBL.DeleteElev(elevID);
                labelDeleteElev.Text = "Stergerea a fost realizata cu succes! ";

            }
            ListElevi();

        }

        private void buttonCancelUpdateProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
