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
    public partial class AddElev : Form
    {
        public AddElev()
        {
            InitializeComponent();
        }

        private void buttonAddElev_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeElev.Text;
            string prenume = textBoxPrenumeElev.Text;
            string user = textBoxUserElev.Text;
            string parola = textBoxParolaElev.Text;
            ElevBL elevBL = new ElevBL();
            if (!string.IsNullOrWhiteSpace(nume) && !string.IsNullOrWhiteSpace(prenume) && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(parola))
            {
                elevBL.AddElev(nume, prenume, user, parola);
                labelMsgElev.Text = "Adaugare cu succes! ";

                textBoxNumeElev.Text = "";
                textBoxPrenumeElev.Text = "";
                textBoxUserElev.Text = "";
                textBoxParolaElev.Text = "";
            }
            else
                labelMsgElev.Text = "Date incomplete ! ";
        }

        private void buttonCancelElev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
