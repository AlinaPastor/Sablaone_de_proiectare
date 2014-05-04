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
    public partial class UpdateAn_Studiu : Form
    {
        public UpdateAn_Studiu()
        {
            InitializeComponent();
            ListAnStudiu();
        }

        private void PopulateUpdateControls()
        {
            int anID = int.Parse(comboBoxAnStudiuUpdate.SelectedValue.ToString());
            An_StudiuBL anBL = new An_StudiuBL();
            DataSet ds = anBL.GetAn_StudiuById(anID);
            textBoxAn_AnStudiu.Text = ds.Tables[0].Rows[0]["an"].ToString();

        }

        private void ListAnStudiu()
        {
            An_StudiuBL anBL = new An_StudiuBL();
            comboBoxAnStudiuUpdate.DisplayMember = "an";
            comboBoxAnStudiuUpdate.ValueMember = "id_an_studiu";
            comboBoxAnStudiuUpdate.DataSource = anBL.GetAni_Studiu().Tables[0];
        }

        private void comboBoxAnStudiuUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateUpdateControls();
        }

        private void ButtonUpdateAnStudiu_Click(object sender, EventArgs e)
        {
            string an = textBoxAn_AnStudiu.Text;

            An_StudiuBL anBL = new An_StudiuBL();
            if (!string.IsNullOrWhiteSpace(an))
            {
                int anID = int.Parse(comboBoxAnStudiuUpdate.SelectedValue.ToString());
                anBL.UpdateAn_Studiu(anID, an);
                labelMsgUpdateAnStudiu.Text = "Actualizarea a fost realizata cu succes! ";
            }
            else
                labelMsgUpdateAnStudiu.Text = "Date incomplete ! ";
            ListAnStudiu();
        }

        private void buttonCancelAnStudiu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
