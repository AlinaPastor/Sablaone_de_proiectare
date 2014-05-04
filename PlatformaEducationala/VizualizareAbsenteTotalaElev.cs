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
    public partial class VizualizareAbsenteTotalaElev : Form
    {
        public VizualizareAbsenteTotalaElev(DataSet absente)
        {
            InitializeComponent();
            Afiseaza(absente);
        }

        private void Afiseaza(DataSet listaAbs)
        {
            for (int i = 0; i < listaAbs.Tables[0].Rows.Count; i++)
            {
                String absenta = "Data: " + listaAbs.Tables[0].Rows[i]["data_absenta"].ToString() + " Motivata: "
                                 + listaAbs.Tables[0].Rows[i]["motivata"].ToString() + " Motivabila: "
                                 + listaAbs.Tables[0].Rows[i]["motivabila"].ToString();
                listBoxAbsenteVizualizare.Items.Add(absenta);
            }
        }

        private void buttonCancelVizAbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
