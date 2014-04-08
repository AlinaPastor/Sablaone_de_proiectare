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
    public partial class AddClasa : Form
    {
        public AddClasa()
        {
            InitializeComponent();
        }

        private void buttonAddClasa_Click(object sender, EventArgs e)
        {
            string nume = textBoxClasaNume.Text;
            
            ClasaBL clasaBL = new ClasaBL();
            if (!string.IsNullOrWhiteSpace(nume))
            {
               clasaBL.AddClasa(nume);
                labelMsgAddClasa.Text = "Adaugare cu succes! ";

                textBoxClasaNume.Text = "";
               
            }
            else
                labelMsgAddClasa.Text = "Date incomplete ! ";
        }


        private void buttonCancelClasa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
