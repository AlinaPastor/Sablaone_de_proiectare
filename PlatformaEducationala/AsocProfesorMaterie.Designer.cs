namespace PlatformaEducationala
{
    partial class AsocProfesorMaterie
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
            this.buttonCancelAsocMateriiProfesori = new System.Windows.Forms.Button();
            this.buttonAsociereMateriiPofesori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProfiAsoc = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriiAsoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancelAsocMateriiProfesori
            // 
            this.buttonCancelAsocMateriiProfesori.Location = new System.Drawing.Point(263, 172);
            this.buttonCancelAsocMateriiProfesori.Name = "buttonCancelAsocMateriiProfesori";
            this.buttonCancelAsocMateriiProfesori.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAsocMateriiProfesori.TabIndex = 17;
            this.buttonCancelAsocMateriiProfesori.Text = "Cancel";
            this.buttonCancelAsocMateriiProfesori.UseVisualStyleBackColor = true;
            this.buttonCancelAsocMateriiProfesori.Click += new System.EventHandler(this.buttonCancelAsocMateriiProfesori_Click);
            // 
            // buttonAsociereMateriiPofesori
            // 
            this.buttonAsociereMateriiPofesori.Location = new System.Drawing.Point(148, 172);
            this.buttonAsociereMateriiPofesori.Name = "buttonAsociereMateriiPofesori";
            this.buttonAsociereMateriiPofesori.Size = new System.Drawing.Size(75, 23);
            this.buttonAsociereMateriiPofesori.TabIndex = 16;
            this.buttonAsociereMateriiPofesori.Text = "Asociere";
            this.buttonAsociereMateriiPofesori.UseVisualStyleBackColor = true;
            this.buttonAsociereMateriiPofesori.Click += new System.EventHandler(this.buttonAsociereMateriiPofesori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Profesori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Materii:";
            // 
            // comboBoxProfiAsoc
            // 
            this.comboBoxProfiAsoc.FormattingEnabled = true;
            this.comboBoxProfiAsoc.Location = new System.Drawing.Point(272, 78);
            this.comboBoxProfiAsoc.Name = "comboBoxProfiAsoc";
            this.comboBoxProfiAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfiAsoc.TabIndex = 13;
            // 
            // comboBoxMateriiAsoc
            // 
            this.comboBoxMateriiAsoc.FormattingEnabled = true;
            this.comboBoxMateriiAsoc.Location = new System.Drawing.Point(35, 78);
            this.comboBoxMateriiAsoc.Name = "comboBoxMateriiAsoc";
            this.comboBoxMateriiAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateriiAsoc.TabIndex = 12;
            // 
            // AsocProfesorMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 327);
            this.Controls.Add(this.buttonCancelAsocMateriiProfesori);
            this.Controls.Add(this.buttonAsociereMateriiPofesori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProfiAsoc);
            this.Controls.Add(this.comboBoxMateriiAsoc);
            this.Name = "AsocProfesorMaterie";
            this.Text = "AsocProfesorMaterie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAsocMateriiProfesori;
        private System.Windows.Forms.Button buttonAsociereMateriiPofesori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProfiAsoc;
        private System.Windows.Forms.ComboBox comboBoxMateriiAsoc;
    }
}