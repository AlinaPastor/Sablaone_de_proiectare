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
    public partial class AbsentaForm : Form
    {
        int id_prof_logat = 0;
        public AbsentaForm(int id)
        {
            InitializeComponent();
            id_prof_logat = id;
            //labelEroareAbsentaForm.Text = id_prof_logat.ToString();
            ListSem();
            ListMaterii();
            ListClasa();
            ListElevi();
           
        }

        private void ListSem()
        {
            SemestruBL semBL = new SemestruBL();
            comboBoxAbsentaSem.DisplayMember = "nr_semestru";
            comboBoxAbsentaSem.ValueMember = "id_semestru";
            comboBoxAbsentaSem.DataSource = semBL.GetSemestre().Tables[0];
        }

        private void ListMaterii()
        {
            MaterieBL materiiBL = new MaterieBL();
            try
            {
                comboBoxAbsentaMaterie.DisplayMember = "nume_materie";
                comboBoxAbsentaMaterie.ValueMember = "id_materie";
                comboBoxAbsentaMaterie.DataSource = materiiBL.GetMaterieByProfId(id_prof_logat).Tables[0];
            }
            catch (Exception e)
            {
                labelEroareAbsentaForm.Text = "Profesorul nu are asociate materii!";
            }
        }

        private void ListClasa()
        {
            int materieID = int.Parse(comboBoxAbsentaMaterie.SelectedValue.ToString());
            try
            {
                ClasaBL clasaBL = new ClasaBL();
                comboBoxAbsentaClasa.DisplayMember = "nume_clasa";
                comboBoxAbsentaClasa.ValueMember = "id_clasa";
                comboBoxAbsentaClasa.DataSource = clasaBL.GetClasaByProfMatId(id_prof_logat, materieID).Tables[0];
            }
            catch (Exception e)
            {
                labelEroareAbsentaForm.Text = "Profesorul nu are clase asociate materiei!";
            }
        }

        private void ListElevi()
        {

            try
            {
                int clasaID = int.Parse(comboBoxAbsentaClasa.SelectedValue.ToString());
                ElevBL elevBL = new ElevBL();

                comboBoxAbsentaElev.DisplayMember = "nume_elev";
                comboBoxAbsentaElev.ValueMember = "id_elev";
                comboBoxAbsentaElev.DataSource = elevBL.GetEleviByClasaId(clasaID).Tables[0];
            }
            catch (Exception e)
            {
                labelEroareAbsentaForm.Text = "Profesorul nu are elevi asociati clasei la care preda!";
            }

        }

        private void buttonAbsentaCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void buttonAbsentaVizualizare_Click(object sender, EventArgs e)
        {
          
            int semID = int.Parse(comboBoxAbsentaSem.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxAbsentaElev.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxAbsentaMaterie.SelectedValue.ToString());
            AbsentaBL absBl = new AbsentaBL();
            DataSet listaAbs = absBl.GetAbsenteByIDuri(semID, elevID, materieID);
            VizualizareAbsente viz = new VizualizareAbsente(listaAbs);
            viz.ShowDialog();
            viz.Dispose();

            
        }

        private void buttonAddAbsenta_Click(object sender, EventArgs e)
        {
            int semID = int.Parse(comboBoxAbsentaSem.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxAbsentaElev.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxAbsentaMaterie.SelectedValue.ToString());
            AddAbsentaForm ab = new AddAbsentaForm(semID, elevID, materieID);
            ab.ShowDialog();
            ab.Dispose();
        }

        private void buttonMotivareAbsenta_Click(object sender, EventArgs e)
        {
            int semID = int.Parse(comboBoxAbsentaSem.SelectedValue.ToString());
            int elevID = int.Parse(comboBoxAbsentaElev.SelectedValue.ToString());
            int materieID = int.Parse(comboBoxAbsentaMaterie.SelectedValue.ToString());
           // AbsentaBL absBl = new AbsentaBL();
            //DataSet listaAbs = absBl.GetAbsenteByIDuri(semID, elevID, materieID);
            MotivareAbsentaForm abs = new MotivareAbsentaForm(semID, elevID, materieID);
            abs.ShowDialog();
            abs.Dispose();

        }

        private void buttonVizAbsCls_Click(object sender, EventArgs e)
        {
            int clasaID = int.Parse(comboBoxAbsentaClasa.SelectedValue.ToString());
           
            AbsentaBL absBl = new AbsentaBL();
            DataSet numarAbs = absBl.GetAbsenteClasa(clasaID);
            TotalAbsClasa viz = new TotalAbsClasa(numarAbs);
            viz.ShowDialog();
            viz.Dispose();
        }

        private void buttonVizAbsClsNemoti_Click(object sender, EventArgs e)
        {
            int clasaID = int.Parse(comboBoxAbsentaClasa.SelectedValue.ToString());

            AbsentaBL absBl = new AbsentaBL();
            DataSet numarAbs = absBl.GetAbsenteClasaNemotivate(clasaID);
            TotalAbsClasa viz = new TotalAbsClasa(numarAbs);
            viz.ShowDialog();
            viz.Dispose();
        }

     

        

       
    }
}
