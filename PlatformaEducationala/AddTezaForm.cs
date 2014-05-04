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
    public partial class AddTezaForm : Form
    {
        int semID, elevID, materieID,clasaID;
        public AddTezaForm(int id_sem, int id_elev, int id_materie, int id_clasa)
        {
            InitializeComponent();
            semID = id_sem;
            elevID = id_elev;
            materieID = id_materie;
            clasaID = id_clasa;
        }

        private void buttonAddTezaFormCncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddTezaForm_Click(object sender, EventArgs e)
        {
           int teza = int.Parse(textBoxAddTeza.Text); 
           NotaBL notaBL = new NotaBL();
            if (teza != 0)
            {
                ClasaBL cls = new ClasaBL();
                DataTable verifTeza =  cls.VerifTeza(materieID,clasaID);
                bool areTeza = bool.Parse(verifTeza.Rows[0]["teza"].ToString());
                if(areTeza)
                {

                
                notaBL.AddTeza(elevID, materieID, semID, teza);
                labelMsgAddTezaForm.Text = "Adaugare teza cu succes!";
                }
                else
                    labelMsgAddTezaForm.Text = "Materia selectat nu are teza la acesta clasa!";
            }
            else
                labelMsgAddTezaForm.Text = "Adaugare esuta, camp incomplet!";
        }
        
    }
}
