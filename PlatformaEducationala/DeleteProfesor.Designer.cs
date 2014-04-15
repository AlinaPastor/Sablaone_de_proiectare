namespace PlatformaEducationala
{
    partial class DeleteProfesor
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDeleteProf = new System.Windows.Forms.ComboBox();
            this.buttonDeleteProf = new System.Windows.Forms.Button();
            this.buttonCancelUpdateProf = new System.Windows.Forms.Button();
            this.labelDeleteProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesori: ";
            // 
            // comboBoxDeleteProf
            // 
            this.comboBoxDeleteProf.FormattingEnabled = true;
            this.comboBoxDeleteProf.Location = new System.Drawing.Point(83, 12);
            this.comboBoxDeleteProf.Name = "comboBoxDeleteProf";
            this.comboBoxDeleteProf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteProf.TabIndex = 1;
            // 
            // buttonDeleteProf
            // 
            this.buttonDeleteProf.Location = new System.Drawing.Point(83, 72);
            this.buttonDeleteProf.Name = "buttonDeleteProf";
            this.buttonDeleteProf.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProf.TabIndex = 2;
            this.buttonDeleteProf.Text = "Delete";
            this.buttonDeleteProf.UseVisualStyleBackColor = true;
            this.buttonDeleteProf.Click += new System.EventHandler(this.buttonDeleteProf_Click);
            // 
            // buttonCancelUpdateProf
            // 
            this.buttonCancelUpdateProf.Location = new System.Drawing.Point(197, 72);
            this.buttonCancelUpdateProf.Name = "buttonCancelUpdateProf";
            this.buttonCancelUpdateProf.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelUpdateProf.TabIndex = 3;
            this.buttonCancelUpdateProf.Text = "Cancel";
            this.buttonCancelUpdateProf.UseVisualStyleBackColor = true;
            this.buttonCancelUpdateProf.Click += new System.EventHandler(this.buttonCancelUpdateProf_Click);
            // 
            // labelDeleteProf
            // 
            this.labelDeleteProf.AutoSize = true;
            this.labelDeleteProf.Location = new System.Drawing.Point(83, 118);
            this.labelDeleteProf.Name = "labelDeleteProf";
            this.labelDeleteProf.Size = new System.Drawing.Size(0, 13);
            this.labelDeleteProf.TabIndex = 4;
            // 
            // DeleteProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 143);
            this.Controls.Add(this.labelDeleteProf);
            this.Controls.Add(this.buttonCancelUpdateProf);
            this.Controls.Add(this.buttonDeleteProf);
            this.Controls.Add(this.comboBoxDeleteProf);
            this.Controls.Add(this.label1);
            this.Name = "DeleteProfesor";
            this.Text = "DeleteProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDeleteProf;
        private System.Windows.Forms.Button buttonDeleteProf;
        private System.Windows.Forms.Button buttonCancelUpdateProf;
        private System.Windows.Forms.Label labelDeleteProf;
    }
}