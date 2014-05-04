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
    public partial class AsocAn_StudiuSemestru : Form
    {
        public AsocAn_StudiuSemestru()
        {
            InitializeComponent();
            ListSem();
            ListAniStudiu();
        }

        private void ListSem()
        {
            SemestruBL semBL = new SemestruBL();
            comboBoxSemAsoc.DisplayMember = "nr_semestru";
            comboBoxSemAsoc.ValueMember = "id_semestru";
            comboBoxSemAsoc.DataSource = semBL.GetSemestre();
        }

        private void ListAniStudiu()
        {
            An_StudiuBL anBL = new An_StudiuBL();
            comboBoxAnStudiuAsoc.DisplayMember = "an";
            comboBoxAnStudiuAsoc.ValueMember = "id_an_studiu";
            comboBoxAnStudiuAsoc.DataSource = anBL.GetAni_Studiu();
        }


        private void buttonCancelAsocSemAnStudiu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAsociereSemAnStudiu_Click(object sender, EventArgs e)
        {
            labelMsgAsocSemAn.Text = "";
            int semID = int.Parse(comboBoxSemAsoc.SelectedValue.ToString());
            int an_studiuID = int.Parse(comboBoxAnStudiuAsoc.SelectedValue.ToString());
            SemestruBL semBL = new SemestruBL();
            semBL.AsocAn_StudiuSemestru(semID, an_studiuID);
            labelMsgAsocSemAn.Text = "Asociere reusita!";
        }
    }
}
