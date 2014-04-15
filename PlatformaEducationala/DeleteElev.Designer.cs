namespace PlatformaEducationala
{
    partial class DeleteElev
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
            this.labelDeleteElev = new System.Windows.Forms.Label();
            this.buttonCancelDeleteElev = new System.Windows.Forms.Button();
            this.buttonDeleteElev = new System.Windows.Forms.Button();
            this.comboBoxDeleteElev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeleteElev
            // 
            this.labelDeleteElev.AutoSize = true;
            this.labelDeleteElev.Location = new System.Drawing.Point(91, 133);
            this.labelDeleteElev.Name = "labelDeleteElev";
            this.labelDeleteElev.Size = new System.Drawing.Size(0, 13);
            this.labelDeleteElev.TabIndex = 9;
            // 
            // buttonCancelDeleteElev
            // 
            this.buttonCancelDeleteElev.Location = new System.Drawing.Point(205, 87);
            this.buttonCancelDeleteElev.Name = "buttonCancelDeleteElev";
            this.buttonCancelDeleteElev.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelDeleteElev.TabIndex = 8;
            this.buttonCancelDeleteElev.Text = "Cancel";
            this.buttonCancelDeleteElev.UseVisualStyleBackColor = true;
            this.buttonCancelDeleteElev.Click += new System.EventHandler(this.buttonCancelUpdateProf_Click);
            // 
            // buttonDeleteElev
            // 
            this.buttonDeleteElev.Location = new System.Drawing.Point(91, 87);
            this.buttonDeleteElev.Name = "buttonDeleteElev";
            this.buttonDeleteElev.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteElev.TabIndex = 7;
            this.buttonDeleteElev.Text = "Delete";
            this.buttonDeleteElev.UseVisualStyleBackColor = true;
            this.buttonDeleteElev.Click += new System.EventHandler(this.buttonDeleteProf_Click);
            // 
            // comboBoxDeleteElev
            // 
            this.comboBoxDeleteElev.FormattingEnabled = true;
            this.comboBoxDeleteElev.Location = new System.Drawing.Point(91, 27);
            this.comboBoxDeleteElev.Name = "comboBoxDeleteElev";
            this.comboBoxDeleteElev.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteElev.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elevi: ";
            // 
            // DeleteElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 182);
            this.Controls.Add(this.labelDeleteElev);
            this.Controls.Add(this.buttonCancelDeleteElev);
            this.Controls.Add(this.buttonDeleteElev);
            this.Controls.Add(this.comboBoxDeleteElev);
            this.Controls.Add(this.label1);
            this.Name = "DeleteElev";
            this.Text = "DeleteElev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteElev;
        private System.Windows.Forms.Button buttonCancelDeleteElev;
        private System.Windows.Forms.Button buttonDeleteElev;
        private System.Windows.Forms.ComboBox comboBoxDeleteElev;
        private System.Windows.Forms.Label label1;
    }
}