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
    public partial class UpdateMaterie : Form
    {
        public UpdateMaterie()
        {
            InitializeComponent();
            ListMaterii();
        }


        private void PopulateUpdateControls()
        {
            int materieID = int.Parse(comboBoxMaterieUpdate.SelectedValue.ToString());
            MaterieBL materieBL = new MaterieBL();
            DataSet ds = materieBL.GetMaterieById(materieID);
            textBoxNumeMaterie.Text = ds.Tables[0].Rows[0]["nume_materie"].ToString();

        }

        private void ListMaterii()
        {
            MaterieBL materieBL = new MaterieBL();
            comboBoxMaterieUpdate.DisplayMember = "nume_materie";
            comboBoxMaterieUpdate.ValueMember = "id_materie";
            comboBoxMaterieUpdate.DataSource = materieBL.GetMaterii().Tables[0];
        }

        private void comboBoxMaterieUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateUpdateControls();

        }
      
        private void ButtonUpdateMaterie_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeMaterie.Text;

            MaterieBL materieBL = new MaterieBL();
            if (!string.IsNullOrWhiteSpace(nume))
            {
                int materieID = int.Parse(comboBoxMaterieUpdate.SelectedValue.ToString());
                materieBL.UpdateMaterie(materieID,nume);
                labelMsgUpdateMaterie.Text = "Actualizarea a fost realizata cu succes! ";
            }
            else
                labelMsgUpdateMaterie.Text = "Date incomplete ! ";
            ListMaterii();
        }


        private void buttonCancelMaterie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

    }
}
