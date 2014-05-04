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
    public partial class MotivareAbsentaForm : Form
    {
        
        public MotivareAbsentaForm(int semID, int  elevID, int materieID)
        {
            InitializeComponent();
            ListAbsente(semID, elevID, materieID);
        }

        private void ListAbsente(int semID, int elevID, int materieID)
        {
            AbsentaBL absBL = new AbsentaBL();
            comboBoxListaAbsenteMotivare.DisplayMember = "data_absenta";
            comboBoxListaAbsenteMotivare.ValueMember = "id_absenta";
            //labelMotivareAbsenta.Text = comboBoxListaAbsenteMotivare.SelectedValue.ToString(); 
            comboBoxListaAbsenteMotivare.DataSource = absBL.GetAbsenteByIDuri(semID, elevID, materieID).Rows;
        }
        

        private void buttonMotiveazaAbsentaCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMotiveazaAbsenta_Click(object sender, EventArgs e)
        {
            AbsentaBL a = new AbsentaBL();
            int idAbs = int.Parse(comboBoxListaAbsenteMotivare.SelectedValue.ToString());
            DataTable m = a.GetMotivabilitateById(idAbs);
            bool motivabila = bool.Parse(m.Rows[0]["motivabila"].ToString());
            if (motivabila == true)
            {
                a.MotivareAbsenta(idAbs);
                labelMotivareAbsenta.Text = "Absenta a fost motivata cu succes!";
            }
            else
                labelMotivareAbsenta.Text = "Absenta nu poate fi motivata pentru ca nu este motivabila!";
        }
    }
}
