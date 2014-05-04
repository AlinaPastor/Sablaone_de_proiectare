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
    public partial class VizualizareNote : Form
    {
        public VizualizareNote(DataSet listaNote)
        {
            InitializeComponent();
            Afiseaza(listaNote);
        }

        private void Afiseaza(DataSet listaNote)
        {
            for (int i = 0; i < listaNote.Tables[0].Rows.Count; i++)
            {
                if (listaNote.Tables[0].Rows[i]["nota"].ToString() != null)
                {
                    String nota = "Nota: " + listaNote.Tables[0].Rows[i]["nota"].ToString() + " Data: "
                                     + listaNote.Tables[0].Rows[i]["data_nota"].ToString();
                    listBoxNoteVizualizare.Items.Add(nota);
                }
            }
            
        }

        private void buttonCancelVizNote_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
