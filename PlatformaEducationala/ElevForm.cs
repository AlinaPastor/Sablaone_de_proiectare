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
    public partial class ElevForm : Form
    {
        int id_elev = 0;
        public ElevForm( int id_user)
        {
            InitializeComponent();
            id_elev = id_user;
        }

        private void vizualizareTotalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbsentaBL abs = new AbsentaBL();
            DataTable absente = abs.GetAbsenteByIDElev(id_elev);
            VizualizareAbsenteTotalaElev absT = new VizualizareAbsenteTotalaElev(absente);
            absT.ShowDialog();
            absT.Dispose();
        }

        private void vizualizareNemotivateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbsentaBL abs = new AbsentaBL();
            DataTable absente = abs.GetAbsenteNemotivateByIDElev(id_elev);
            VizualizareAbsentaNemotivataElev absT = new VizualizareAbsentaNemotivataElev(absente);
            absT.ShowDialog();
            absT.Dispose();
        }
    }
}
