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
    public partial class AddAn_Studiu : Form
    {
        public AddAn_Studiu()
        {
            InitializeComponent();
        }

        private void buttonAddAnStudiu_Click(object sender, EventArgs e)
        {
            string an = textBoxAddAnStudiu.Text;

            An_StudiuBL anBL = new An_StudiuBL();
            if (!string.IsNullOrWhiteSpace(an))
            {
                anBL.AddAn_Studiu(an);
                labelMsgAddAnStudiu.Text = "Adaugare cu succes! ";

                textBoxAddAnStudiu.Text = "";

            }
            else
                labelMsgAddAnStudiu.Text = "Date incomplete ! ";
        }

        private void buttonCancelAnStudiu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
