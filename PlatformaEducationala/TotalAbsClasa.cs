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
        public TotalAbsClasa(DataTable nrAbs)
        {
            InitializeComponent();
            Afiseaza( nrAbs);
        }


        private void Afiseaza(DataTable nrAbs)
        {

            labelNrAbsCls.Text = nrAbs.Rows[0][nrAbs.Columns[0]].ToString();
        }

        private void buttonCancelVizAbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
