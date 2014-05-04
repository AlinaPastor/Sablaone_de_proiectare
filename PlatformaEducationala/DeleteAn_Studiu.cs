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
    public partial class DeleteAn_Studiu : Form
    {
        public DeleteAn_Studiu()
        {
            InitializeComponent();
            ListAnStudiu();
        }

        private void ListAnStudiu()
        {
            An_StudiuBL anBL = new An_StudiuBL();
            comboBoxDeleteAnStudiu.DisplayMember = "an";
            comboBoxDeleteAnStudiu.ValueMember = "id_an_studiu";
            comboBoxDeleteAnStudiu.DataSource = anBL.GetAni_Studiu();
        }


        private void buttonCancelDeleteAnStudiu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteAnStudiu_Click(object sender, EventArgs e)
        {

            int anID = int.Parse(comboBoxDeleteAnStudiu.SelectedValue.ToString());
            if (MessageBox.Show("Sigur vreti sa stergeti anul scolar?", "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               An_StudiuBL anBL = new An_StudiuBL();
                anBL.DeleteAn_Studiu(anID);
                labelDeleteAnStudiu.Text = "Stergerea a fost realizata cu succes! ";

            }
            ListAnStudiu();

        }
    }
}
