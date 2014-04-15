namespace PlatformaEducationala
{
    partial class UpdateClasa
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
            this.labelProf = new System.Windows.Forms.Label();
            this.comboBoxClasaUpdate = new System.Windows.Forms.ComboBox();
            this.buttonCancelClasa = new System.Windows.Forms.Button();
            this.ButtonUpdateClasa = new System.Windows.Forms.Button();
            this.textBoxNumeClasa = new System.Windows.Forms.TextBox();
            this.labelNumeProf = new System.Windows.Forms.Label();
            this.labelMsgUpdateClasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.Location = new System.Drawing.Point(31, 25);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(36, 13);
            this.labelProf.TabIndex = 43;
            this.labelProf.Text = "Clase:";
            // 
            // comboBoxClasaUpdate
            // 
            this.comboBoxClasaUpdate.FormattingEnabled = true;
            this.comboBoxClasaUpdate.Location = new System.Drawing.Point(89, 18);
            this.comboBoxClasaUpdate.Name = "comboBoxClasaUpdate";
            this.comboBoxClasaUpdate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasaUpdate.TabIndex = 42;
            //this.comboBoxClasaUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasaUpdate_SelectedIndexChanged);
            // 
            // buttonCancelClasa
            // 
            this.buttonCancelClasa.Location = new System.Drawing.Point(157, 128);
            this.buttonCancelClasa.Name = "buttonCancelClasa";
            this.buttonCancelClasa.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelClasa.TabIndex = 41;
            this.buttonCancelClasa.Text = "Cancel";
            this.buttonCancelClasa.UseVisualStyleBackColor = true;
            this.buttonCancelClasa.Click += new System.EventHandler(this.buttonCancelClasa_Click);
            // 
            // ButtonUpdateClasa
            // 
            this.ButtonUpdateClasa.Location = new System.Drawing.Point(50, 128);
            this.ButtonUpdateClasa.Name = "ButtonUpdateClasa";
            this.ButtonUpdateClasa.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdateClasa.TabIndex = 40;
            this.ButtonUpdateClasa.Text = "Update";
            this.ButtonUpdateClasa.UseVisualStyleBackColor = true;
            // 
            // textBoxNumeClasa
            // 
            this.textBoxNumeClasa.Location = new System.Drawing.Point(89, 69);
            this.textBoxNumeClasa.Name = "textBoxNumeClasa";
            this.textBoxNumeClasa.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeClasa.TabIndex = 39;
            // 
            // labelNumeProf
            // 
            this.labelNumeProf.AutoSize = true;
            this.labelNumeProf.Location = new System.Drawing.Point(28, 77);
            this.labelNumeProf.Name = "labelNumeProf";
            this.labelNumeProf.Size = new System.Drawing.Size(41, 13);
            this.labelNumeProf.TabIndex = 38;
            this.labelNumeProf.Text = "Nume: ";
            // 
            // labelMsgUpdateClasa
            // 
            this.labelMsgUpdateClasa.AutoSize = true;
            this.labelMsgUpdateClasa.Location = new System.Drawing.Point(50, 171);
            this.labelMsgUpdateClasa.Name = "labelMsgUpdateClasa";
            this.labelMsgUpdateClasa.Size = new System.Drawing.Size(0, 13);
            this.labelMsgUpdateClasa.TabIndex = 44;
            // 
            // UpdateClasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelMsgUpdateClasa);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.comboBoxClasaUpdate);
            this.Controls.Add(this.buttonCancelClasa);
            this.Controls.Add(this.ButtonUpdateClasa);
            this.Controls.Add(this.textBoxNumeClasa);
            this.Controls.Add(this.labelNumeProf);
            this.Name = "UpdateClasa";
            this.Text = "UpdateClasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.ComboBox comboBoxClasaUpdate;
        private System.Windows.Forms.Button buttonCancelClasa;
        private System.Windows.Forms.Button ButtonUpdateClasa;
        private System.Windows.Forms.TextBox textBoxNumeClasa;
        private System.Windows.Forms.Label labelNumeProf;
        private System.Windows.Forms.Label labelMsgUpdateClasa;
    }
}