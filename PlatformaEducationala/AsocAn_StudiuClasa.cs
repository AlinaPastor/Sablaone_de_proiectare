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
    public partial class AsocAn_StudiuClasa : Form
    {
        public AsocAn_StudiuClasa()
        {
            InitializeComponent();
            ListClasa();
            ListAniStudiu();
        }

        private void ListClasa()
        {
            ClasaBL clasaBL = new ClasaBL();
            comboBoxClaseAsoc.DisplayMember = "nume_clasa";
            comboBoxClaseAsoc.ValueMember = "id_clasa";
            comboBoxClaseAsoc.DataSource = clasaBL.GetClase();
        }

        private void ListAniStudiu()
        {
            An_StudiuBL anBL = new An_StudiuBL();
            comboBoxAnStudiuAsoc.DisplayMember = "an";
            comboBoxAnStudiuAsoc.ValueMember = "id_an_studiu";
            comboBoxAnStudiuAsoc.DataSource = anBL.GetAni_Studiu();
        }


        private void buttonAsociereClasaAnStudiu_Click(object sender, EventArgs e)
        {
            int clasaID = int.Parse(comboBoxClaseAsoc.SelectedValue.ToString());
            int an_studiuID = int.Parse(comboBoxAnStudiuAsoc.SelectedValue.ToString());
            ClasaBL clasaBL = new ClasaBL();
            clasaBL.AsocAn_StudiuClasa(an_studiuID, clasaID);

        }

        private void buttonCancelAsocClasaAnStudiu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
