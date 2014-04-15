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
    public partial class TotalAbsClasa : Form
    {
        public TotalAbsClasa(DataSet nrAbs)
        {
            InitializeComponent();
            Afiseaza( nrAbs);
        }


        private void Afiseaza(DataSet nrAbs)
        {

            labelNrAbsCls.Text = nrAbs.Tables[0].Rows[0][0].ToString();
        }

        private void buttonCancelVizAbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
