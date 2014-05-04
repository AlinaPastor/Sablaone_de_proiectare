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
    public partial class AnulareNotaForm : Form
    {
        int id_sem, id_elev, id_mat;
        public AnulareNotaForm(int semID, int elevID, int materieID)
        {
            InitializeComponent();
            id_sem = semID;
            id_elev = elevID;
            id_mat = materieID;
            ListaNote();

        }

        private void ListaNote()
        {
            NotaBL notaBL = new NotaBL();
            comboBoxListaNote.DisplayMember = "nota";
            comboBoxListaNote.ValueMember = "id_nota";
            comboBoxListaNote.DataSource = notaBL.GetNoteByIDuri( id_elev, id_mat, id_sem);
        }
        private void buttonMotiveazaAbsentaCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnuleazaNota_Click(object sender, EventArgs e)
        {
            try
            {
                MedieSemestruBL med = new MedieSemestruBL();
                NotaBL notaBL = new NotaBL();
                int idNota = int.Parse(comboBoxListaNote.SelectedValue.ToString());
                DataTable m = med.GetMedieSemIDuri(id_sem, id_elev, id_mat);
                int medie = 0;
                if (m != null)
                    medie = int.Parse(m.Rows[0]["medie_semstru"].ToString());

                if (medie == 0)
                {
                    notaBL.DeleteNota(idNota);
                    labelAnulareNota.Text = "Nota a fost stearsa cu succes!";
                }
                else
                    labelAnulareNota.Text = "Nota nu poate fi stearsa pentru ca media e deja incheiata!";
            }
            catch(Exception exc) 
            {
                labelAnulareNota.Text = "Media pentru datele dumneavoasta nu figureaza in baza de date, nota nu poate fi stearsa!";
            }

            NotaBL notaBl = new NotaBL();
            DataTable listaNote = notaBl.GetNoteByIDuri(id_elev, id_mat, id_sem);
            NotaForm nf = new NotaForm();
            nf.setListaNote(listaNote);
            
        }
    }
}
