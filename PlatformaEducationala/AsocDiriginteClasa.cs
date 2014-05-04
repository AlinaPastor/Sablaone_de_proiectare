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
    public partial class AsocDiriginteClasa : Form
    {
        public AsocDiriginteClasa()
        {
            InitializeComponent();
            ListClasa();
            ListProfesori();
        }

        private void ListClasa()
        {
            ClasaBL clasaBL = new ClasaBL();
            comboBoxClaseAsoc.DisplayMember = "nume_clasa";
            comboBoxClaseAsoc.ValueMember = "id_clasa";
            comboBoxClaseAsoc.DataSource = clasaBL.GetClase();
        }

        private void ListProfesori()
        {
            ProfesorBL profBL = new ProfesorBL();
            comboBoxProfiAsoc.DisplayMember = "nume_profesor";
            comboBoxProfiAsoc.ValueMember = "id_profesor";
            comboBoxProfiAsoc.DataSource = profBL.GetProfesori();
        }

        private void buttonAsociereClasaDirig_Click(object sender, EventArgs e)
        {
            int clasaID = int.Parse(comboBoxClaseAsoc.SelectedValue.ToString());
            int profID = int.Parse(comboBoxProfiAsoc.SelectedValue.ToString());
            ClasaBL clasaBL = new ClasaBL();
            clasaBL.AsocDiriginteClasa(profID, clasaID);
        }

        private void buttonCancelAsocClasaDirig_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
