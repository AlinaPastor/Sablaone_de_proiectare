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
    public partial class NotaForm : Form
    {
        
        int id_prof_logat;
        DataSet listaNote = null;
        public void setListaNote(DataSet d)
        {
            listaNote = d;
        }
        public NotaForm()
        {
            InitializeComponent();
        }
        public NotaForm( int id_user)
        {
            InitializeComponent();
            id_prof_logat = id_user;
            ListSem();
            ListMaterii();
            ListClasa();
            ListElevi();
        }

        private void ListSem()
        {
            SemestruBL semBL = new SemestruBL();
            comboBoxNotaSem.DisplayMember = "nr_semestru";
            comboBoxNotaSem.ValueMember = "id_semestru";
            comboBoxNotaSem.DataSource = semBL.GetSemestre().Tables[0];
        }

        private void ListMaterii()
        {
            MaterieBL materiiBL = new MaterieBL();
            try
            {
                comboBoxNotaMaterie.DisplayMember = "nume_materie";
                comboBoxNotaMaterie.ValueMember = "id_materie";
                comboBoxNotaMaterie.DataSource = materiiBL.GetMaterieByProfId(id_prof_logat).Tables[0];
            }
            catch (Exception e)
            {
                labelEroareNotaForm.Text = "Profesorul nu are asociate materii!";
            }
        }

        private void ListClasa()
        {
            int materieID = int.Parse(comboBoxNotaMaterie.SelectedValue.ToString());
            try
            {
                ClasaBL clasaBL = new ClasaBL();
                comboBoxNotaClasa.DisplayMember = "nume_clasa";
                comboBoxNotaClasa.ValueMember = "id_clasa";
                comboBoxNotaClasa.DataSource = clasaBL.GetClasaByProfMatId(id_prof_logat, materieID).Tables[0];
            }
            catch (Exception e)
            {
                labelEroareNotaForm.Text = "Profesorul nu are clase asociate materiei!";
            }
        }

        private void ListElevi()
        {

            try
            {
                int clasaID = int.Parse(comboBoxNotaClasa.SelectedValue.ToString());
                ElevBL elevBL = new ElevBL();

                comboBoxNotaElev.DisplayMember = "nume_elev";
                comboBoxNotaElev.ValueMember = "id_elev";
                comboBoxNotaElev.DataSource = elevBL.GetEleviByClasaId(clasaID).Tables[0];
            }
            catch (Exception e)
            {
                labelEroareNotaForm.Text = "Profesorul nu are elevi asociati clasei la care preda!";
            }

        }

        private void buttonNotaCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNotaVizualizare_Click(object sender, EventArgs e)
        {
            int semID = int.Parse(comboBoxNotaSem.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxNotaElev.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxNotaMaterie.SelectedValue.ToString());
            NotaBL notaBl = new NotaBL();
            listaNote = notaBl.GetNoteByIDuri(elevID, materieID, semID);
            VizualizareNote notviz = new VizualizareNote(listaNote);
            notviz.ShowDialog();
            notviz.Dispose();
        }

        private void buttonAddNota_Click(object sender, EventArgs e)
        {
            int semID = int.Parse(comboBoxNotaSem.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxNotaElev.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxNotaMaterie.SelectedValue.ToString());
            AddNotaForm addNota = new AddNotaForm(semID, elevID, materieID);
            addNota.ShowDialog();
            addNota.Dispose();
        }

        private void buttonAnulareNota_Click(object sender, EventArgs e)
        {
            NotaBL notaBl = new NotaBL();
            int semID = int.Parse(comboBoxNotaSem.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxNotaElev.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxNotaMaterie.SelectedValue.ToString());
            AnulareNotaForm anulN = new AnulareNotaForm(semID, elevID, materieID);
            anulN.ShowDialog();
            anulN.Dispose();
            

        }

        private void buttonAddTeza_Click(object sender, EventArgs e)
        {
            int semID = int.Parse(comboBoxNotaSem.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxNotaElev.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxNotaMaterie.SelectedValue.ToString());
            int clasaID = int.Parse(comboBoxNotaClasa.SelectedValue.ToString());
            AddTezaForm anulN = new AddTezaForm(semID, elevID, materieID, clasaID);
            anulN.ShowDialog();
            anulN.Dispose();
        }

        private void CalcMediePeSem_Click(object sender, EventArgs e)
        {
//             try
//             {
                int semID = int.Parse(comboBoxNotaSem.SelectedValue.ToString());
                int elevID = int.Parse(comboBoxNotaElev.SelectedValue.ToString());
                int materieID = int.Parse(comboBoxNotaMaterie.SelectedValue.ToString());
                int clasaId = int.Parse(comboBoxNotaClasa.SelectedValue.ToString());
                NotaBL notBL = new NotaBL();
                ClasaBL clBl = new ClasaBL();
                DataSet t = clBl.VerifTeza(materieID, clasaId);
                bool tezica = bool.Parse(t.Tables[0].Rows[0]["teza"].ToString());
                DataSet note = notBL.GetNoteByIDuri1(elevID, materieID, semID);
                if (note.Tables[0].Rows.Count >= 3)
                {
                    int medie = 0;
                    int teza = 0;
                    for (int i = 0; i < note.Tables[0].Rows.Count; i++)

                        //if (note.Tables[0].Rows[i]["nota"] != null)
                            medie = medie + int.Parse(note.Tables[0].Rows[i]["nota"].ToString());
                        //else
                            //teza = int.Parse(note.Tables[0].Rows[i]["teza"].ToString());
                    medie = medie / note.Tables[0].Rows.Count;
                    if (tezica )
                    {

                        t = notBL.GetTezaByIDuri(elevID, materieID, semID);
                        teza = int.Parse(t.Tables[0].Rows[0]["teza"].ToString());
                        medie = (medie * 3 + teza) / 4;
                    }
                   
                   

                    MedieSemestruBL mdsem = new MedieSemestruBL();
                    mdsem.AddMedie(elevID, materieID, semID, medie);
                    labelEroareNotaForm.Text = "Media este: " + medie.ToString();
                }
                else
                    labelEroareNotaForm.Text = "Media nu poate fi calculata deoarece nu sunt minim 3 note!";



            //}
          //  catch(Exception except)
           // {
           //     labelEroareNotaForm.Text = "eroare";
           // }
        }
      
    }
}
