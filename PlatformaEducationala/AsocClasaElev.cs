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
    public partial class AsocClasaElev : Form
    {
        public AsocClasaElev()
        {
            InitializeComponent();
            ListClasa();
            ListElevi();
        }

        private void ListClasa()
        {
            ClasaBL clasaBL = new ClasaBL();
            comboBoxClaseAsoc.DisplayMember = "nume_clasa";
            comboBoxClaseAsoc.ValueMember = "id_clasa";
            comboBoxClaseAsoc.DataSource = clasaBL.GetClase();
        }

        private void ListElevi()
        {
            ElevBL elevBL = new ElevBL();
            comboBoxEleviAsoc.DisplayMember = "nume_elev";
            comboBoxEleviAsoc.ValueMember = "id_elev";
            comboBoxEleviAsoc.DataSource = elevBL.GetEleviFaraClasa();
        }

        private void buttonCancelAsocClasaElev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAsociereClasaElev_Click(object sender, EventArgs e)
        {
            int clasaID = int.Parse(comboBoxClaseAsoc.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxEleviAsoc.SelectedValue.ToString());
            ElevBL elevBl = new ElevBL();
            elevBl.AsocElevClasa(elevID, clasaID);
            ListElevi();

        }

        private void comboBoxClaseAsoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBoxEleviAsoc.DataSource = null;
           // ListElevi();

        }
    }
}
