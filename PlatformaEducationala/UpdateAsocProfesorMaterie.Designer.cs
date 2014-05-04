namespace PlatformaEducationala
{
    partial class UpdateAsocProfesorMaterie
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
            this.buttonCancelAsocUpMateriiProfesori = new System.Windows.Forms.Button();
            this.buttonUpdateMateriiPofesori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProfiAsocUp = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriiAsocUp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUpdateAsocProf = new System.Windows.Forms.ComboBox();
            this.labelMasUpdateAscoProfMaterie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelAsocUpMateriiProfesori
            // 
            this.buttonCancelAsocUpMateriiProfesori.Location = new System.Drawing.Point(252, 205);
            this.buttonCancelAsocUpMateriiProfesori.Name = "buttonCancelAsocUpMateriiProfesori";
            this.buttonCancelAsocUpMateriiProfesori.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAsocUpMateriiProfesori.TabIndex = 23;
            this.buttonCancelAsocUpMateriiProfesori.Text = "Cancel";
            this.buttonCancelAsocUpMateriiProfesori.UseVisualStyleBackColor = true;
            this.buttonCancelAsocUpMateriiProfesori.Click += new System.EventHandler(this.buttonCancelAsocUpMateriiProfesori_Click);
            // 
            // buttonUpdateMateriiPofesori
            // 
            this.buttonUpdateMateriiPofesori.Location = new System.Drawing.Point(154, 205);
            this.buttonUpdateMateriiPofesori.Name = "buttonUpdateMateriiPofesori";
            this.buttonUpdateMateriiPofesori.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMateriiPofesori.TabIndex = 22;
            this.buttonUpdateMateriiPofesori.Text = "Update";
            this.buttonUpdateMateriiPofesori.UseVisualStyleBackColor = true;
            this.buttonUpdateMateriiPofesori.Click += new System.EventHandler(this.buttonUpdateMateriiPofesori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Profesori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Materii:";
            // 
            // comboBoxProfiAsocUp
            // 
            this.comboBoxProfiAsocUp.FormattingEnabled = true;
            this.comboBoxProfiAsocUp.Location = new System.Drawing.Point(276, 77);
            this.comboBoxProfiAsocUp.Name = "comboBoxProfiAsocUp";
            this.comboBoxProfiAsocUp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfiAsocUp.TabIndex = 19;
            // 
            // comboBoxMateriiAsocUp
            // 
            this.comboBoxMateriiAsocUp.FormattingEnabled = true;
            this.comboBoxMateriiAsocUp.Location = new System.Drawing.Point(39, 77);
            this.comboBoxMateriiAsocUp.Name = "comboBoxMateriiAsocUp";
            this.comboBoxMateriiAsocUp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateriiAsocUp.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Profesor nou: ";
            // 
            // comboBoxUpdateAsocProf
            // 
            this.comboBoxUpdateAsocProf.FormattingEnabled = true;
            this.comboBoxUpdateAsocProf.Location = new System.Drawing.Point(135, 144);
            this.comboBoxUpdateAsocProf.Name = "comboBoxUpdateAsocProf";
            this.comboBoxUpdateAsocProf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUpdateAsocProf.TabIndex = 25;
            // 
            // labelMasUpdateAscoProfMaterie
            // 
            this.labelMasUpdateAscoProfMaterie.AutoSize = true;
            this.labelMasUpdateAscoProfMaterie.Location = new System.Drawing.Point(64, 263);
            this.labelMasUpdateAscoProfMaterie.Name = "labelMasUpdateAscoProfMaterie";
            this.labelMasUpdateAscoProfMaterie.Size = new System.Drawing.Size(0, 13);
            this.labelMasUpdateAscoProfMaterie.TabIndex = 26;
            // 
            // UpdateAsocProfesorMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 315);
            this.Controls.Add(this.labelMasUpdateAscoProfMaterie);
            this.Controls.Add(this.comboBoxUpdateAsocProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelAsocUpMateriiProfesori);
            this.Controls.Add(this.buttonUpdateMateriiPofesori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProfiAsocUp);
            this.Controls.Add(this.comboBoxMateriiAsocUp);
            this.Name = "UpdateAsocProfesorMaterie";
            this.Text = "UpdateAsocProfesorMaterie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAsocUpMateriiProfesori;
        private System.Windows.Forms.Button buttonUpdateMateriiPofesori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProfiAsocUp;
        private System.Windows.Forms.ComboBox comboBoxMateriiAsocUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUpdateAsocProf;
        private System.Windows.Forms.Label labelMasUpdateAscoProfMaterie;
    }
}