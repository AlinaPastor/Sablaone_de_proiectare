namespace PlatformaEducationala
{
    partial class DeleteAn_Studiu
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
            this.labelDeleteAnStudiu = new System.Windows.Forms.Label();
            this.buttonCancelDeleteAnStudiu = new System.Windows.Forms.Button();
            this.buttonDeleteAnStudiu = new System.Windows.Forms.Button();
            this.comboBoxDeleteAnStudiu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeleteAnStudiu
            // 
            this.labelDeleteAnStudiu.AutoSize = true;
            this.labelDeleteAnStudiu.Location = new System.Drawing.Point(83, 141);
            this.labelDeleteAnStudiu.Name = "labelDeleteAnStudiu";
            this.labelDeleteAnStudiu.Size = new System.Drawing.Size(0, 13);
            this.labelDeleteAnStudiu.TabIndex = 19;
            // 
            // buttonCancelDeleteAnStudiu
            // 
            this.buttonCancelDeleteAnStudiu.Location = new System.Drawing.Point(197, 95);
            this.buttonCancelDeleteAnStudiu.Name = "buttonCancelDeleteAnStudiu";
            this.buttonCancelDeleteAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelDeleteAnStudiu.TabIndex = 18;
            this.buttonCancelDeleteAnStudiu.Text = "Cancel";
            this.buttonCancelDeleteAnStudiu.UseVisualStyleBackColor = true;
            this.buttonCancelDeleteAnStudiu.Click += new System.EventHandler(this.buttonCancelDeleteAnStudiu_Click);
            // 
            // buttonDeleteAnStudiu
            // 
            this.buttonDeleteAnStudiu.Location = new System.Drawing.Point(83, 95);
            this.buttonDeleteAnStudiu.Name = "buttonDeleteAnStudiu";
            this.buttonDeleteAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAnStudiu.TabIndex = 17;
            this.buttonDeleteAnStudiu.Text = "Delete";
            this.buttonDeleteAnStudiu.UseVisualStyleBackColor = true;
            this.buttonDeleteAnStudiu.Click += new System.EventHandler(this.buttonDeleteAnStudiu_Click);
            // 
            // comboBoxDeleteAnStudiu
            // 
            this.comboBoxDeleteAnStudiu.FormattingEnabled = true;
            this.comboBoxDeleteAnStudiu.Location = new System.Drawing.Point(83, 35);
            this.comboBoxDeleteAnStudiu.Name = "comboBoxDeleteAnStudiu";
            this.comboBoxDeleteAnStudiu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteAnStudiu.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ani scolari: ";
            // 
            // DeleteAn_Studiu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 225);
            this.Controls.Add(this.labelDeleteAnStudiu);
            this.Controls.Add(this.buttonCancelDeleteAnStudiu);
            this.Controls.Add(this.buttonDeleteAnStudiu);
            this.Controls.Add(this.comboBoxDeleteAnStudiu);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAn_Studiu";
            this.Text = "DeleteAn_Studiu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteAnStudiu;
        private System.Windows.Forms.Button buttonCancelDeleteAnStudiu;
        private System.Windows.Forms.Button buttonDeleteAnStudiu;
        private System.Windows.Forms.ComboBox comboBoxDeleteAnStudiu;
        private System.Windows.Forms.Label label1;
    }
}