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
    public partial class AddAbsentaForm : Form
    {
        int semID, elevID, materieID;
        public AddAbsentaForm(int id_sem,int id_elev, int id_materie)
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
            bool motivata = bool.Parse(textBoxAddAbsMotivata.Text);
            bool motivabila = bool.Parse(textBoxAddAbsMotivabila.Text);
            AbsentaBL absBL = new AbsentaBL();
            if (motivata != null && motivabila != null)
            {
                absBL.AddAbsenta(semID, elevID, materieID, motivata, motivabila);
                labelMsgAddAbsentaForm.Text = "Adaugare absenta cu succes!";
            }
            else
                labelMsgAddAbsentaForm.Text = "Adaugare esuta, camp incomplet!";
        }
    }
}
