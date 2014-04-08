namespace PlatformaEducationala
{
    partial class AsocAn_StudiuSemestru
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
            this.buttonCancelAsocSemAnStudiu = new System.Windows.Forms.Button();
            this.buttonAsociereSemAnStudiu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAnStudiuAsoc = new System.Windows.Forms.ComboBox();
            this.comboBoxSemAsoc = new System.Windows.Forms.ComboBox();
            this.labelMsgAsocSemAn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelAsocSemAnStudiu
            // 
            this.buttonCancelAsocSemAnStudiu.Location = new System.Drawing.Point(243, 149);
            this.buttonCancelAsocSemAnStudiu.Name = "buttonCancelAsocSemAnStudiu";
            this.buttonCancelAsocSemAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAsocSemAnStudiu.TabIndex = 23;
            this.buttonCancelAsocSemAnStudiu.Text = "Cancel";
            this.buttonCancelAsocSemAnStudiu.UseVisualStyleBackColor = true;
            this.buttonCancelAsocSemAnStudiu.Click += new System.EventHandler(this.buttonCancelAsocSemAnStudiu_Click);
            // 
            // buttonAsociereSemAnStudiu
            // 
            this.buttonAsociereSemAnStudiu.Location = new System.Drawing.Point(151, 149);
            this.buttonAsociereSemAnStudiu.Name = "buttonAsociereSemAnStudiu";
            this.buttonAsociereSemAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonAsociereSemAnStudiu.TabIndex = 22;
            this.buttonAsociereSemAnStudiu.Text = "Asociere";
            this.buttonAsociereSemAnStudiu.UseVisualStyleBackColor = true;
            this.buttonAsociereSemAnStudiu.Click += new System.EventHandler(this.buttonAsociereSemAnStudiu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ani scolari:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Semestre:";
            // 
            // comboBoxAnStudiuAsoc
            // 
            this.comboBoxAnStudiuAsoc.FormattingEnabled = true;
            this.comboBoxAnStudiuAsoc.Location = new System.Drawing.Point(274, 76);
            this.comboBoxAnStudiuAsoc.Name = "comboBoxAnStudiuAsoc";
            this.comboBoxAnStudiuAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnStudiuAsoc.TabIndex = 19;
            // 
            // comboBoxSemAsoc
            // 
            this.comboBoxSemAsoc.FormattingEnabled = true;
            this.comboBoxSemAsoc.Location = new System.Drawing.Point(37, 76);
            this.comboBoxSemAsoc.Name = "comboBoxSemAsoc";
            this.comboBoxSemAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemAsoc.TabIndex = 18;
            // 
            // labelMsgAsocSemAn
            // 
            this.labelMsgAsocSemAn.AutoSize = true;
            this.labelMsgAsocSemAn.Location = new System.Drawing.Point(45, 211);
            this.labelMsgAsocSemAn.Name = "labelMsgAsocSemAn";
            this.labelMsgAsocSemAn.Size = new System.Drawing.Size(0, 13);
            this.labelMsgAsocSemAn.TabIndex = 24;
            // 
            // AsocAn_StudiuSemestru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 262);
            this.Controls.Add(this.labelMsgAsocSemAn);
            this.Controls.Add(this.buttonCancelAsocSemAnStudiu);
            this.Controls.Add(this.buttonAsociereSemAnStudiu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAnStudiuAsoc);
            this.Controls.Add(this.comboBoxSemAsoc);
            this.Name = "AsocAn_StudiuSemestru";
            this.Text = "AsocAn_StudiuSemestru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAsocSemAnStudiu;
        private System.Windows.Forms.Button buttonAsociereSemAnStudiu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAnStudiuAsoc;
        private System.Windows.Forms.ComboBox comboBoxSemAsoc;
        private System.Windows.Forms.Label labelMsgAsocSemAn;
    }
}