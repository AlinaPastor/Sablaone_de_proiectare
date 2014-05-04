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
    public partial class UpdateElev : Form
    {
        public UpdateElev()
        {
            InitializeComponent();
            ListElevi();
        }

        private void PopulateUpdateControls()
        {
            int elevID = int.Parse(comboBoxElevUpdate.SelectedValue.ToString());
            ElevBL elevBL = new ElevBL();
            DataTable ds = elevBL.GetEleviById(elevID);
            textBoxNumeElev.Text = ds.Rows[0]["nume_elev"].ToString();
            textBoxPrenumeElev.Text = ds.Rows[0]["prenume_elev"].ToString();
            textBoxUserElev.Text = ds.Rows[0]["user_elev"].ToString();
            textBoxParolaElev.Text = ds.Rows[0]["parola_elev"].ToString();
        }

        private void ListElevi()
        {
            ElevBL elevBL = new ElevBL();
            comboBoxElevUpdate.DisplayMember = "nume_elev";
            comboBoxElevUpdate.ValueMember = "id_elev";
            comboBoxElevUpdate.DataSource = elevBL.GetElevi();
        }

        private void buttonCancelProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxElevUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateUpdateControls();
        }

        private void ButtonUpdateProf_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeElev.Text;
            string prenume = textBoxPrenumeElev.Text;
            string user = textBoxUserElev.Text;
            string parola = textBoxParolaElev.Text;
            ElevBL elevBL = new ElevBL();
            if (!string.IsNullOrWhiteSpace(nume) && !string.IsNullOrWhiteSpace(prenume) && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(parola))
            {
                int elevID = int.Parse(comboBoxElevUpdate.SelectedValue.ToString());
                elevBL.UpdateElev(elevID ,nume, prenume, user, parola);
                labelMsgUpdateElev.Text = "Actualizarea a fost realizata cu succes! ";
            }
            else
                labelMsgUpdateElev.Text = "Date incomplete ! ";
            ListElevi();
        }


    }
}
