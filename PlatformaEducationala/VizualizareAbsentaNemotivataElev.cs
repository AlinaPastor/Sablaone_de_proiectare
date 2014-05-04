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
    public partial class VizualizareAbsentaNemotivataElev : Form
    {
        public VizualizareAbsentaNemotivataElev(DataTable absenteNemotivate)
        {
            InitializeComponent();
            Afiseaza(absenteNemotivate);
        }

        private void Afiseaza(DataTable listaAbs)
        {
            for (int i = 0; i < listaAbs.Rows.Count; i++)
            {
                String absenta = "Data: " + listaAbs.Rows[i]["data_absenta"].ToString() + " Motivata: "
                                 + listaAbs.Rows[i]["motivata"].ToString() + " Motivabila: "
                                 + listaAbs.Rows[i]["motivabila"].ToString();
                listBoxAbsenteVizualizare.Items.Add(absenta);
            }
        }

        private void buttonCancelVizAbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
