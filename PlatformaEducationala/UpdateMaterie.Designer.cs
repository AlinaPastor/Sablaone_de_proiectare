namespace PlatformaEducationala
{
    partial class UpdateMaterie
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
            this.labelMsgUpdateMaterie = new System.Windows.Forms.Label();
            this.labelProf = new System.Windows.Forms.Label();
            this.comboBoxMaterieUpdate = new System.Windows.Forms.ComboBox();
            this.buttonCancelMaterie = new System.Windows.Forms.Button();
            this.ButtonUpdateMaterie = new System.Windows.Forms.Button();
            this.textBoxNumeMaterie = new System.Windows.Forms.TextBox();
            this.labelNumeProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMsgUpdateMaterie
            // 
            this.labelMsgUpdateMaterie.AutoSize = true;
            this.labelMsgUpdateMaterie.Location = new System.Drawing.Point(62, 201);
            this.labelMsgUpdateMaterie.Name = "labelMsgUpdateMaterie";
            this.labelMsgUpdateMaterie.Size = new System.Drawing.Size(0, 13);
            this.labelMsgUpdateMaterie.TabIndex = 51;
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.Location = new System.Drawing.Point(43, 55);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(41, 13);
            this.labelProf.TabIndex = 50;
            this.labelProf.Text = "Materii:";
            // 
            // comboBoxMaterieUpdate
            // 
            this.comboBoxMaterieUpdate.FormattingEnabled = true;
            this.comboBoxMaterieUpdate.Location = new System.Drawing.Point(101, 48);
            this.comboBoxMaterieUpdate.Name = "comboBoxMaterieUpdate";
            this.comboBoxMaterieUpdate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterieUpdate.TabIndex = 49;
            this.comboBoxMaterieUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterieUpdate_SelectedIndexChanged);
            // 
            // buttonCancelMaterie
            // 
            this.buttonCancelMaterie.Location = new System.Drawing.Point(169, 158);
            this.buttonCancelMaterie.Name = "buttonCancelMaterie";
            this.buttonCancelMaterie.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelMaterie.TabIndex = 48;
            this.buttonCancelMaterie.Text = "Cancel";
            this.buttonCancelMaterie.UseVisualStyleBackColor = true;
            this.buttonCancelMaterie.Click += new System.EventHandler(this.buttonCancelMaterie_Click);
            // 
            // ButtonUpdateMaterie
            // 
            this.ButtonUpdateMaterie.Location = new System.Drawing.Point(62, 158);
            this.ButtonUpdateMaterie.Name = "ButtonUpdateMaterie";
            this.ButtonUpdateMaterie.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdateMaterie.TabIndex = 47;
            this.ButtonUpdateMaterie.Text = "Update";
            this.ButtonUpdateMaterie.UseVisualStyleBackColor = true;
            this.ButtonUpdateMaterie.Click += new System.EventHandler(this.ButtonUpdateMaterie_Click);
            // 
            // textBoxNumeMaterie
            // 
            this.textBoxNumeMaterie.Location = new System.Drawing.Point(101, 99);
            this.textBoxNumeMaterie.Name = "textBoxNumeMaterie";
            this.textBoxNumeMaterie.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeMaterie.TabIndex = 46;
            // 
            // labelNumeProf
            // 
            this.labelNumeProf.AutoSize = true;
            this.labelNumeProf.Location = new System.Drawing.Point(40, 107);
            this.labelNumeProf.Name = "labelNumeProf";
            this.labelNumeProf.Size = new System.Drawing.Size(41, 13);
            this.labelNumeProf.TabIndex = 45;
            this.labelNumeProf.Text = "Nume: ";
            // 
            // UpdateMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelMsgUpdateMaterie);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.comboBoxMaterieUpdate);
            this.Controls.Add(this.buttonCancelMaterie);
            this.Controls.Add(this.ButtonUpdateMaterie);
            this.Controls.Add(this.textBoxNumeMaterie);
            this.Controls.Add(this.labelNumeProf);
            this.Name = "UpdateMaterie";
            this.Text = "UpdateMaterie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsgUpdateMaterie;
        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.ComboBox comboBoxMaterieUpdate;
        private System.Windows.Forms.Button buttonCancelMaterie;
        private System.Windows.Forms.Button ButtonUpdateMaterie;
        private System.Windows.Forms.TextBox textBoxNumeMaterie;
        private System.Windows.Forms.Label labelNumeProf;
    }
}