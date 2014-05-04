namespace PlatformaEducationala
{
    partial class UpdateElev
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
            this.comboBoxElevUpdate = new System.Windows.Forms.ComboBox();
            this.buttonCancelProf = new System.Windows.Forms.Button();
            this.ButtonUpdateElev = new System.Windows.Forms.Button();
            this.textBoxParolaElev = new System.Windows.Forms.TextBox();
            this.textBoxUserElev = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeElev = new System.Windows.Forms.TextBox();
            this.textBoxNumeElev = new System.Windows.Forms.TextBox();
            this.labelParolaProf = new System.Windows.Forms.Label();
            this.labelUserProf = new System.Windows.Forms.Label();
            this.labelPrenumeProf = new System.Windows.Forms.Label();
            this.labelNumeProf = new System.Windows.Forms.Label();
            this.labelMsgUpdateElev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.Location = new System.Drawing.Point(36, 23);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(33, 13);
            this.labelProf.TabIndex = 37;
            this.labelProf.Text = "Elevi:";
            // 
            // comboBoxElevUpdate
            // 
            this.comboBoxElevUpdate.FormattingEnabled = true;
            this.comboBoxElevUpdate.Location = new System.Drawing.Point(94, 16);
            this.comboBoxElevUpdate.Name = "comboBoxElevUpdate";
            this.comboBoxElevUpdate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElevUpdate.TabIndex = 36;
            this.comboBoxElevUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxElevUpdate_SelectedIndexChanged);
            // 
            // buttonCancelProf
            // 
            this.buttonCancelProf.Location = new System.Drawing.Point(186, 219);
            this.buttonCancelProf.Name = "buttonCancelProf";
            this.buttonCancelProf.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelProf.TabIndex = 34;
            this.buttonCancelProf.Text = "Cancel";
            this.buttonCancelProf.UseVisualStyleBackColor = true;
            this.buttonCancelProf.Click += new System.EventHandler(this.buttonCancelProf_Click);
            // 
            // ButtonUpdateElev
            // 
            this.ButtonUpdateElev.Location = new System.Drawing.Point(58, 219);
            this.ButtonUpdateElev.Name = "ButtonUpdateElev";
            this.ButtonUpdateElev.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdateElev.TabIndex = 33;
            this.ButtonUpdateElev.Text = "Update";
            this.ButtonUpdateElev.UseVisualStyleBackColor = true;
            this.ButtonUpdateElev.Click += new System.EventHandler(this.ButtonUpdateProf_Click);
            // 
            // textBoxParolaElev
            // 
            this.textBoxParolaElev.Location = new System.Drawing.Point(94, 151);
            this.textBoxParolaElev.Name = "textBoxParolaElev";
            this.textBoxParolaElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxParolaElev.TabIndex = 32;
            // 
            // textBoxUserElev
            // 
            this.textBoxUserElev.Location = new System.Drawing.Point(94, 124);
            this.textBoxUserElev.Name = "textBoxUserElev";
            this.textBoxUserElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserElev.TabIndex = 31;
            // 
            // textBoxPrenumeElev
            // 
            this.textBoxPrenumeElev.Location = new System.Drawing.Point(94, 94);
            this.textBoxPrenumeElev.Name = "textBoxPrenumeElev";
            this.textBoxPrenumeElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenumeElev.TabIndex = 30;
            // 
            // textBoxNumeElev
            // 
            this.textBoxNumeElev.Location = new System.Drawing.Point(94, 67);
            this.textBoxNumeElev.Name = "textBoxNumeElev";
            this.textBoxNumeElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeElev.TabIndex = 29;
            // 
            // labelParolaProf
            // 
            this.labelParolaProf.AutoSize = true;
            this.labelParolaProf.Location = new System.Drawing.Point(33, 159);
            this.labelParolaProf.Name = "labelParolaProf";
            this.labelParolaProf.Size = new System.Drawing.Size(40, 13);
            this.labelParolaProf.TabIndex = 28;
            this.labelParolaProf.Text = "Parola:";
            // 
            // labelUserProf
            // 
            this.labelUserProf.AutoSize = true;
            this.labelUserProf.Location = new System.Drawing.Point(33, 132);
            this.labelUserProf.Name = "labelUserProf";
            this.labelUserProf.Size = new System.Drawing.Size(35, 13);
            this.labelUserProf.TabIndex = 27;
            this.labelUserProf.Text = "User: ";
            // 
            // labelPrenumeProf
            // 
            this.labelPrenumeProf.AutoSize = true;
            this.labelPrenumeProf.Location = new System.Drawing.Point(33, 102);
            this.labelPrenumeProf.Name = "labelPrenumeProf";
            this.labelPrenumeProf.Size = new System.Drawing.Size(55, 13);
            this.labelPrenumeProf.TabIndex = 26;
            this.labelPrenumeProf.Text = "Prenume: ";
            // 
            // labelNumeProf
            // 
            this.labelNumeProf.AutoSize = true;
            this.labelNumeProf.Location = new System.Drawing.Point(33, 75);
            this.labelNumeProf.Name = "labelNumeProf";
            this.labelNumeProf.Size = new System.Drawing.Size(41, 13);
            this.labelNumeProf.TabIndex = 25;
            this.labelNumeProf.Text = "Nume: ";
            // 
            // labelMsgUpdateElev
            // 
            this.labelMsgUpdateElev.AutoSize = true;
            this.labelMsgUpdateElev.Location = new System.Drawing.Point(58, 268);
            this.labelMsgUpdateElev.Name = "labelMsgUpdateElev";
            this.labelMsgUpdateElev.Size = new System.Drawing.Size(0, 13);
            this.labelMsgUpdateElev.TabIndex = 38;
            // 
            // UpdateElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 293);
            this.Controls.Add(this.labelMsgUpdateElev);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.comboBoxElevUpdate);
            this.Controls.Add(this.buttonCancelProf);
            this.Controls.Add(this.ButtonUpdateElev);
            this.Controls.Add(this.textBoxParolaElev);
            this.Controls.Add(this.textBoxUserElev);
            this.Controls.Add(this.textBoxPrenumeElev);
            this.Controls.Add(this.textBoxNumeElev);
            this.Controls.Add(this.labelParolaProf);
            this.Controls.Add(this.labelUserProf);
            this.Controls.Add(this.labelPrenumeProf);
            this.Controls.Add(this.labelNumeProf);
            this.Name = "UpdateElev";
            this.Text = "UpdateElev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.ComboBox comboBoxElevUpdate;
        private System.Windows.Forms.Button buttonCancelProf;
        private System.Windows.Forms.Button ButtonUpdateElev;
        private System.Windows.Forms.TextBox textBoxParolaElev;
        private System.Windows.Forms.TextBox textBoxUserElev;
        private System.Windows.Forms.TextBox textBoxPrenumeElev;
        private System.Windows.Forms.TextBox textBoxNumeElev;
        private System.Windows.Forms.Label labelParolaProf;
        private System.Windows.Forms.Label labelUserProf;
        private System.Windows.Forms.Label labelPrenumeProf;
        private System.Windows.Forms.Label labelNumeProf;
        private System.Windows.Forms.Label labelMsgUpdateElev;
    }
}