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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProfesor formaAdaugare = new AddProfesor();
            formaAdaugare.ShowDialog();
            formaAdaugare.Dispose();
        }

        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProfesor formaUpdate = new UpdateProfesor();
            formaUpdate.ShowDialog();
            formaUpdate.Dispose();

        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProfesor formaDelete = new DeleteProfesor();
            formaDelete.ShowDialog();
            formaDelete.Dispose();

        }

        private void adaugareToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddElev formaAdaugare = new AddElev();
            formaAdaugare.ShowDialog();
            formaAdaugare.Dispose(); 
        }

        private void modificareToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            UpdateElev formaUpdate = new UpdateElev();
            formaUpdate.ShowDialog();
            formaUpdate.Dispose();
        }

        private void stergereToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteElev formaDelete = new DeleteElev();
            formaDelete.ShowDialog();
            formaDelete.Dispose();

        }

        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClasa formaAdaugare = new AddClasa();
            formaAdaugare.ShowDialog();
            formaAdaugare.Dispose(); 

        }

        private void modificareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateClasa formaUpdate = new UpdateClasa();
            formaUpdate.ShowDialog();
            formaUpdate.Dispose();
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteClasa formaDelete = new DeleteClasa();
            formaDelete.ShowDialog();
            formaDelete.Dispose();

        }

        private void elevClasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsocClasaElev asocEC = new AsocClasaElev();
            asocEC.ShowDialog();
            asocEC.Dispose();
        }

        private void adaugareToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            AddMaterie formaAdaugare = new AddMaterie();
            formaAdaugare.ShowDialog();
            formaAdaugare.Dispose(); 
        }

        private void modificaerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMaterie formaUpdate = new UpdateMaterie();
            formaUpdate.ShowDialog();
            formaUpdate.Dispose();
        }

        private void stergereToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteMaterie formaDelete = new DeleteMaterie();
            formaDelete.ShowDialog();
            formaDelete.Dispose();

        }

        private void adaugareToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AddAn_Studiu formaAdaugare = new AddAn_Studiu();
            formaAdaugare.ShowDialog();
            formaAdaugare.Dispose(); 

        }

        private void modificareToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UpdateAn_Studiu formaUpdate = new UpdateAn_Studiu();
            formaUpdate.ShowDialog();
            formaUpdate.Dispose();

        }

        private void stergereToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DeleteAn_Studiu formaDelete = new DeleteAn_Studiu();
            formaDelete.ShowDialog();
            formaDelete.Dispose();

        }

        private void diriginteClasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsocDiriginteClasa asocDC = new AsocDiriginteClasa();
            asocDC.ShowDialog();
            asocDC.Dispose();

        }

        private void anDeStudiuClasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsocAn_StudiuClasa asocASC = new AsocAn_StudiuClasa();
            asocASC.ShowDialog();
            asocASC.Dispose();

        }

        private void profesorMaterieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsocProfesorMaterie asocMP= new AsocProfesorMaterie();
            asocMP.ShowDialog();
            asocMP.Dispose();

        }

        private void updateProfesorMaterieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAsocProfesorMaterie asocMP = new UpdateAsocProfesorMaterie();
            asocMP.ShowDialog();
            asocMP.Dispose();

        }

        private void profesorClasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsocProfesorClasa asocPMC = new AsocProfesorClasa();
            asocPMC.ShowDialog();
            asocPMC.Dispose();

        }

        private void updateProfesorClasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAsocProfesorClasa asocPMC = new UpdateAsocProfesorClasa();
            asocPMC.ShowDialog();
            asocPMC.Dispose();
        }

        private void anDeStudiuSemestruToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AsocAn_StudiuSemestru asocASS = new AsocAn_StudiuSemestru();
            asocASS.ShowDialog();
            asocASS.Dispose();
        }

       
    }
}
