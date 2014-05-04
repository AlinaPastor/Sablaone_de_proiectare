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
    public partial class UpdateClasa : Form
    {
        public UpdateClasa()
        {
            InitializeComponent();
            ListClasa();
        }


        private void PopulateUpdateControls()
        {
            int clasaID = int.Parse(comboBoxClasaUpdate.SelectedValue.ToString());
            ClasaBL clasaBL = new ClasaBL();
            DataTable ds = clasaBL.GetClasaById(clasaID);
            textBoxNumeClasa.Text = ds.Rows[0]["nume_clasa"].ToString();
            
        }

        private void ListClasa()
        {
            ClasaBL clasaBL = new ClasaBL();
            comboBoxClasaUpdate.DisplayMember = "nume_clasa";
            comboBoxClasaUpdate.ValueMember = "id_clasa";
            comboBoxClasaUpdate.DataSource = clasaBL.GetClase();
        }

        

        private void comboBoxElevUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateUpdateControls();
        }

        private void ButtonUpdateProf_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeClasa.Text;
           
            ClasaBL clasaBL = new ClasaBL();
            if (!string.IsNullOrWhiteSpace(nume))
            {

                int clasaID = int.Parse(comboBoxClasaUpdate.SelectedValue.ToString());
                clasaBL.UpdateClasa(clasaID, nume);
                labelMsgUpdateClasa.Text = "Actualizarea a fost realizata cu succes! ";
            }
            else
                labelMsgUpdateClasa.Text = "Date incomplete ! ";
            ListClasa();
        }

       


        private void buttonCancelClasa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
    }
}
