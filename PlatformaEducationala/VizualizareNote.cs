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
        public VizualizareNote(DataTable listaNote)
        {
            InitializeComponent();
            Afiseaza(listaNote);
        }

        private void Afiseaza(DataTable listaNote)
        {
            for (int i = 0; i < listaNote.Rows.Count; i++)
            {
                if (listaNote.Rows[i]["nota"].ToString() != null)
                {
                    String nota = "Nota: " + listaNote.Rows[i]["nota"].ToString() + " Data: "
                                     + listaNote.Rows[i]["data_nota"].ToString();
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
