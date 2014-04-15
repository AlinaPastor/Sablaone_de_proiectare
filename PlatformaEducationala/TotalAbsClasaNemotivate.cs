using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlatformaEducationala
{
    public partial class TotalAbsClasaNemotivate : Form
    {
        public TotalAbsClasaNemotivate(DataSet nrAbsN)
        {
            InitializeComponent();
            Afiseaza(nrAbsN);
        }

        private void Afiseaza(DataSet nrAbsN)
        {

            labelNrAbsCls.Text = nrAbsN.Tables[0].Rows[0][0].ToString();
        }


        private void buttonCancelVizAbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNrAbsCls_Click(object sender, EventArgs e)
        {

        }
    }
}
