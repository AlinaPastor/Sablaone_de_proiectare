namespace PlatformaEducationala
{
    partial class AnulareNotaForm
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
            this.labelAnulareNota = new System.Windows.Forms.Label();
            this.buttonAnulareNotaCancel = new System.Windows.Forms.Button();
            this.buttonAnuleazaNota = new System.Windows.Forms.Button();
            this.comboBoxListaNote = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAnulareNota
            // 
            this.labelAnulareNota.AutoSize = true;
            this.labelAnulareNota.Location = new System.Drawing.Point(46, 151);
            this.labelAnulareNota.Name = "labelAnulareNota";
            this.labelAnulareNota.Size = new System.Drawing.Size(0, 13);
            this.labelAnulareNota.TabIndex = 9;
            // 
            // buttonAnulareNotaCancel
            // 
            this.buttonAnulareNotaCancel.Location = new System.Drawing.Point(250, 104);
            this.buttonAnulareNotaCancel.Name = "buttonAnulareNotaCancel";
            this.buttonAnulareNotaCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonAnulareNotaCancel.TabIndex = 8;
            this.buttonAnulareNotaCancel.Text = "Cancel";
            this.buttonAnulareNotaCancel.UseVisualStyleBackColor = true;
            this.buttonAnulareNotaCancel.Click += new System.EventHandler(this.buttonMotiveazaAbsentaCancel_Click);
            // 
            // buttonAnuleazaNota
            // 
            this.buttonAnuleazaNota.Location = new System.Drawing.Point(140, 104);
            this.buttonAnuleazaNota.Name = "buttonAnuleazaNota";
            this.buttonAnuleazaNota.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuleazaNota.TabIndex = 7;
            this.buttonAnuleazaNota.Text = "Anuleaza";
            this.buttonAnuleazaNota.UseVisualStyleBackColor = true;
            this.buttonAnuleazaNota.Click += new System.EventHandler(this.buttonAnuleazaNota_Click);
            // 
            // comboBoxListaNote
            // 
            this.comboBoxListaNote.FormattingEnabled = true;
            this.comboBoxListaNote.Location = new System.Drawing.Point(140, 28);
            this.comboBoxListaNote.Name = "comboBoxListaNote";
            this.comboBoxListaNote.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListaNote.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nota: ";
            // 
            // AnulareNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 262);
            this.Controls.Add(this.labelAnulareNota);
            this.Controls.Add(this.buttonAnulareNotaCancel);
            this.Controls.Add(this.buttonAnuleazaNota);
            this.Controls.Add(this.comboBoxListaNote);
            this.Controls.Add(this.label1);
            this.Name = "AnulareNotaForm";
            this.Text = "AnulareNotaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnulareNota;
        private System.Windows.Forms.Button buttonAnulareNotaCancel;
        private System.Windows.Forms.Button buttonAnuleazaNota;
        private System.Windows.Forms.ComboBox comboBoxListaNote;
        private System.Windows.Forms.Label label1;
    }
}