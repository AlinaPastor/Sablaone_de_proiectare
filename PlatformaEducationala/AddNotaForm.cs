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
    public partial class AddNotaForm : Form
    {
        int semID, elevID, materieID;
        public AddNotaForm(int id_sem, int id_elev, int id_materie)
        {
            InitializeComponent();
            semID = id_sem;
            elevID = id_elev;
            materieID = id_materie;
        }

        private void buttonAddAbsentaFormCncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddAbsForm_Click(object sender, EventArgs e)
        {
            int nota = int.Parse(textBoxAddNota.Text);
            
           NotaBL notaBL = new NotaBL();
            if (nota != 0)
            {
                notaBL.AddNota(elevID, materieID, semID, nota);
                labelMsgAddNotaForm.Text = "Adaugare nota cu succes!";
            }
            else
                labelMsgAddNotaForm.Text = "Adaugare esuta, camp incomplet!";
        }
    }
}
