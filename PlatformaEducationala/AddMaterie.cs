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
    public partial class AddMaterie : Form
    {
        public AddMaterie()
        {
            InitializeComponent();
        }



        private void buttonCancelMaterie_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonAddMaterie_Click(object sender, EventArgs e)
        {
            string nume = textBoxMaterieNume.Text;

            MaterieBL materieBL = new MaterieBL();
            if (!string.IsNullOrWhiteSpace(nume))
            {
                materieBL.AddMaterie(nume);
                labelMsgAddMaterie.Text = "Adaugare cu succes! ";

                textBoxMaterieNume.Text = "";

            }
            else
                labelMsgAddMaterie.Text = "Date incomplete ! ";

        }
    }
}
