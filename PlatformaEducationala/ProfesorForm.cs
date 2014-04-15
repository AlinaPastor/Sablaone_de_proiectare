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
    public partial class ProfesorForm : Form
    {
        int id_user = 0;
        public ProfesorForm(int id)
        {
            InitializeComponent();
            id_user = id;
            
        }

        private void absenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            AbsentaForm formaAbsenta = new AbsentaForm(id_user);
            formaAbsenta.ShowDialog();
            formaAbsenta.Dispose();
            
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotaForm formaAbsenta = new NotaForm(id_user);
            formaAbsenta.ShowDialog();
            formaAbsenta.Dispose();

        }
    }
}
