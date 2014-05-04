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
    public partial class AsocProfesorClasa : Form
    {
        public AsocProfesorClasa()
        {
            InitializeComponent();
            ListMaterii();
           //ListProfesori();
            ListClasa();
        }

        private void ListMaterii()
        {
            MaterieBL materiiBL = new MaterieBL();
            comboBoxMateriiAsocPMC.DisplayMember = "nume_materie";
            comboBoxMateriiAsocPMC.ValueMember = "id_materie";
            comboBoxMateriiAsocPMC.DataSource = materiiBL.GetMaterii();
           
        }

        private void ListProfesori()
        {
            
          
                ProfesorBL profBL = new ProfesorBL();
                int id_materie = int.Parse(comboBoxMateriiAsocPMC.SelectedValue.ToString());
                comboBoxProfiAsocPMC.DisplayMember = "nume_profesor";
                comboBoxProfiAsocPMC.ValueMember = "id_profesor";
                comboBoxProfiAsocPMC.DataSource = profBL.GetProfesoriByMaterieId(id_materie).Rows;
         
              
          
        }

        private void ListClasa()
        {
            ClasaBL clasaBL = new ClasaBL();
            comboBoxClaseAsocPMC.DisplayMember = "nume_clasa";
            comboBoxClaseAsocPMC.ValueMember = "id_clasa";
            comboBoxClaseAsocPMC.DataSource = clasaBL.GetClase();
        }


        private void buttonCancelAsocProfMatClasa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAsocProfMatClasa_Click(object sender, EventArgs e)
        {
            int profID = int.Parse(comboBoxProfiAsocPMC.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxMateriiAsocPMC.SelectedValue.ToString());
            int clasaID = int.Parse(comboBoxClaseAsocPMC.SelectedValue.ToString());
            bool teza = bool.Parse(textBoxTezaAsocPMC.Text);
            ClasaBL clasaBL = new ClasaBL();
            clasaBL.AsocProfesorClasa(profID, materieID,clasaID,teza);
            labelMsgAsocPMC.Text = "Asociere reusita!";
        }

        private void comboBoxMateriiAsocPMC_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProfiAsocPMC.DataSource = null;
            ListProfesori();
           
        }

       
    }
}
