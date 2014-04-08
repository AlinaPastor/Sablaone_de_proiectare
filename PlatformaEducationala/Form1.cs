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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            labelEroare.Text = "";
            
        }


        private void buttonLogare_Click(object sender, EventArgs e)
        {
            int tipUser = 0;
            if (radioButtonProfesor.Checked)
                tipUser = 1;
            if (radioButtonDiriginte.Checked)
                tipUser = 2;
            if (radioButtonElev.Checked)
                tipUser = 3;
            if (radioButtonAdmin.Checked)
                tipUser = 4;

            string user = textBoxUser.Text;
            string parola = textBoxParola.Text;

            LoginBL loginBL = new LoginBL();

            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(parola))
            {
                try
                {
                    if (loginBL.Login(user, parola, tipUser).Tables[0] != null)
                    {
                        DataSet result = loginBL.Login(user, parola, tipUser);
                        int id_user = int.Parse(result.Tables[0].Rows[0][0].ToString());

                        //redirectare formular in functie de tip user
                        if (tipUser == 4)
                        {

                            AdminForm formaAdmin = new AdminForm();
                            formaAdmin.ShowDialog();
                            formaAdmin.Dispose();

                        }
                        if (tipUser == 1)
                        {
                            ProfesorForm formaProfesor = new ProfesorForm(id_user);
                            formaProfesor.ShowDialog();
                            formaProfesor.Dispose();

                        }

                        if (tipUser == 3)
                        {
                            ElevForm formaElev = new ElevForm(id_user);
                            formaElev.ShowDialog();
                            formaElev.Dispose();

                        }

                    }


                    else
                        labelEroare.Text = "Numele de utilizator sau parola nu sunt valide!";


                }
                catch (Exception excep)
                {
                    labelEroare.Text = "Numele de utilizator si parola nu sunt valide pt ceea ce ati bifat!";
                }

            }


        }
    }
}
