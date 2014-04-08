namespace PlatformaEducationala
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonProfesor = new System.Windows.Forms.RadioButton();
            this.radioButtonDiriginte = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonElev = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonLogare = new System.Windows.Forms.Button();
            this.labelEroare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonProfesor
            // 
            this.radioButtonProfesor.AutoSize = true;
            this.radioButtonProfesor.Location = new System.Drawing.Point(53, 62);
            this.radioButtonProfesor.Name = "radioButtonProfesor";
            this.radioButtonProfesor.Size = new System.Drawing.Size(64, 17);
            this.radioButtonProfesor.TabIndex = 0;
            this.radioButtonProfesor.TabStop = true;
            this.radioButtonProfesor.Tag = "1";
            this.radioButtonProfesor.Text = "Profesor";
            this.radioButtonProfesor.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiriginte
            // 
            this.radioButtonDiriginte.AutoSize = true;
            this.radioButtonDiriginte.Location = new System.Drawing.Point(53, 85);
            this.radioButtonDiriginte.Name = "radioButtonDiriginte";
            this.radioButtonDiriginte.Size = new System.Drawing.Size(63, 17);
            this.radioButtonDiriginte.TabIndex = 1;
            this.radioButtonDiriginte.TabStop = true;
            this.radioButtonDiriginte.Tag = "2";
            this.radioButtonDiriginte.Text = "Diriginte";
            this.radioButtonDiriginte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logare ca : ";
            // 
            // radioButtonElev
            // 
            this.radioButtonElev.AutoSize = true;
            this.radioButtonElev.Location = new System.Drawing.Point(53, 108);
            this.radioButtonElev.Name = "radioButtonElev";
            this.radioButtonElev.Size = new System.Drawing.Size(46, 17);
            this.radioButtonElev.TabIndex = 3;
            this.radioButtonElev.TabStop = true;
            this.radioButtonElev.Tag = "3";
            this.radioButtonElev.Text = "Elev";
            this.radioButtonElev.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(53, 131);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAdmin.TabIndex = 4;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Tag = "4";
            this.radioButtonAdmin.Text = "Administrator";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parola:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(68, 164);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 7;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(68, 192);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(100, 20);
            this.textBoxParola.TabIndex = 8;
            // 
            // buttonLogare
            // 
            this.buttonLogare.Location = new System.Drawing.Point(197, 189);
            this.buttonLogare.Name = "buttonLogare";
            this.buttonLogare.Size = new System.Drawing.Size(75, 23);
            this.buttonLogare.TabIndex = 9;
            this.buttonLogare.Text = "Logare";
            this.buttonLogare.UseVisualStyleBackColor = true;
            this.buttonLogare.Click += new System.EventHandler(this.buttonLogare_Click);
            // 
            // labelEroare
            // 
            this.labelEroare.AutoSize = true;
            this.labelEroare.Location = new System.Drawing.Point(57, 233);
            this.labelEroare.Name = "labelEroare";
            this.labelEroare.Size = new System.Drawing.Size(0, 13);
            this.labelEroare.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 262);
            this.Controls.Add(this.labelEroare);
            this.Controls.Add(this.buttonLogare);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonElev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonDiriginte);
            this.Controls.Add(this.radioButtonProfesor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonProfesor;
        private System.Windows.Forms.RadioButton radioButtonDiriginte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonElev;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonLogare;
        private System.Windows.Forms.Label labelEroare;
    }
}

