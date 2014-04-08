namespace PlatformaEducationala
{
    partial class DeleteClasa
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
            this.labelDeleteClasa = new System.Windows.Forms.Label();
            this.buttonCancelDeleteClasa = new System.Windows.Forms.Button();
            this.buttonDeleteClasa = new System.Windows.Forms.Button();
            this.comboBoxDeleteClasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeleteClasa
            // 
            this.labelDeleteClasa.AutoSize = true;
            this.labelDeleteClasa.Location = new System.Drawing.Point(75, 137);
            this.labelDeleteClasa.Name = "labelDeleteClasa";
            this.labelDeleteClasa.Size = new System.Drawing.Size(0, 13);
            this.labelDeleteClasa.TabIndex = 14;
            // 
            // buttonCancelDeleteClasa
            // 
            this.buttonCancelDeleteClasa.Location = new System.Drawing.Point(189, 91);
            this.buttonCancelDeleteClasa.Name = "buttonCancelDeleteClasa";
            this.buttonCancelDeleteClasa.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelDeleteClasa.TabIndex = 13;
            this.buttonCancelDeleteClasa.Text = "Cancel";
            this.buttonCancelDeleteClasa.UseVisualStyleBackColor = true;
            this.buttonCancelDeleteClasa.Click += new System.EventHandler(this.buttonCancelDeleteClasa_Click);
            // 
            // buttonDeleteClasa
            // 
            this.buttonDeleteClasa.Location = new System.Drawing.Point(75, 91);
            this.buttonDeleteClasa.Name = "buttonDeleteClasa";
            this.buttonDeleteClasa.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteClasa.TabIndex = 12;
            this.buttonDeleteClasa.Text = "Delete";
            this.buttonDeleteClasa.UseVisualStyleBackColor = true;
            this.buttonDeleteClasa.Click += new System.EventHandler(this.buttonDeleteClasa_Click);
            // 
            // comboBoxDeleteClasa
            // 
            this.comboBoxDeleteClasa.FormattingEnabled = true;
            this.comboBoxDeleteClasa.Location = new System.Drawing.Point(75, 31);
            this.comboBoxDeleteClasa.Name = "comboBoxDeleteClasa";
            this.comboBoxDeleteClasa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteClasa.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clase: ";
            // 
            // DeleteClasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 190);
            this.Controls.Add(this.labelDeleteClasa);
            this.Controls.Add(this.buttonCancelDeleteClasa);
            this.Controls.Add(this.buttonDeleteClasa);
            this.Controls.Add(this.comboBoxDeleteClasa);
            this.Controls.Add(this.label1);
            this.Name = "DeleteClasa";
            this.Text = "DeleteClasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteClasa;
        private System.Windows.Forms.Button buttonCancelDeleteClasa;
        private System.Windows.Forms.Button buttonDeleteClasa;
        private System.Windows.Forms.ComboBox comboBoxDeleteClasa;
        private System.Windows.Forms.Label label1;
    }
}