namespace PlatformaEducationala
{
    partial class UpdateAn_Studiu
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
            this.labelMsgUpdateAnStudiu = new System.Windows.Forms.Label();
            this.labelProf = new System.Windows.Forms.Label();
            this.comboBoxAnStudiuUpdate = new System.Windows.Forms.ComboBox();
            this.buttonCancelAnStudiu = new System.Windows.Forms.Button();
            this.ButtonUpdateAnStudiu = new System.Windows.Forms.Button();
            this.textBoxAn_AnStudiu = new System.Windows.Forms.TextBox();
            this.labelNumeProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMsgUpdateAnStudiu
            // 
            this.labelMsgUpdateAnStudiu.AutoSize = true;
            this.labelMsgUpdateAnStudiu.Location = new System.Drawing.Point(48, 174);
            this.labelMsgUpdateAnStudiu.Name = "labelMsgUpdateAnStudiu";
            this.labelMsgUpdateAnStudiu.Size = new System.Drawing.Size(0, 13);
            this.labelMsgUpdateAnStudiu.TabIndex = 51;
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.Location = new System.Drawing.Point(29, 28);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(58, 13);
            this.labelProf.TabIndex = 50;
            this.labelProf.Text = "Ani scolari:";
            // 
            // comboBoxAnStudiuUpdate
            // 
            this.comboBoxAnStudiuUpdate.FormattingEnabled = true;
            this.comboBoxAnStudiuUpdate.Location = new System.Drawing.Point(87, 21);
            this.comboBoxAnStudiuUpdate.Name = "comboBoxAnStudiuUpdate";
            this.comboBoxAnStudiuUpdate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnStudiuUpdate.TabIndex = 49;
            this.comboBoxAnStudiuUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnStudiuUpdate_SelectedIndexChanged);
            // 
            // buttonCancelAnStudiu
            // 
            this.buttonCancelAnStudiu.Location = new System.Drawing.Point(155, 131);
            this.buttonCancelAnStudiu.Name = "buttonCancelAnStudiu";
            this.buttonCancelAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAnStudiu.TabIndex = 48;
            this.buttonCancelAnStudiu.Text = "Cancel";
            this.buttonCancelAnStudiu.UseVisualStyleBackColor = true;
            this.buttonCancelAnStudiu.Click += new System.EventHandler(this.buttonCancelAnStudiu_Click);
            // 
            // ButtonUpdateAnStudiu
            // 
            this.ButtonUpdateAnStudiu.Location = new System.Drawing.Point(48, 131);
            this.ButtonUpdateAnStudiu.Name = "ButtonUpdateAnStudiu";
            this.ButtonUpdateAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdateAnStudiu.TabIndex = 47;
            this.ButtonUpdateAnStudiu.Text = "Update";
            this.ButtonUpdateAnStudiu.UseVisualStyleBackColor = true;
            this.ButtonUpdateAnStudiu.Click += new System.EventHandler(this.ButtonUpdateAnStudiu_Click);
            // 
            // textBoxAn_AnStudiu
            // 
            this.textBoxAn_AnStudiu.Location = new System.Drawing.Point(87, 72);
            this.textBoxAn_AnStudiu.Name = "textBoxAn_AnStudiu";
            this.textBoxAn_AnStudiu.Size = new System.Drawing.Size(100, 20);
            this.textBoxAn_AnStudiu.TabIndex = 46;
            // 
            // labelNumeProf
            // 
            this.labelNumeProf.AutoSize = true;
            this.labelNumeProf.Location = new System.Drawing.Point(26, 80);
            this.labelNumeProf.Name = "labelNumeProf";
            this.labelNumeProf.Size = new System.Drawing.Size(57, 13);
            this.labelNumeProf.TabIndex = 45;
            this.labelNumeProf.Text = "An scolar: ";
            // 
            // UpdateAn_Studiu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelMsgUpdateAnStudiu);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.comboBoxAnStudiuUpdate);
            this.Controls.Add(this.buttonCancelAnStudiu);
            this.Controls.Add(this.ButtonUpdateAnStudiu);
            this.Controls.Add(this.textBoxAn_AnStudiu);
            this.Controls.Add(this.labelNumeProf);
            this.Name = "UpdateAn_Studiu";
            this.Text = "UpdateAn_Studiu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsgUpdateAnStudiu;
        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.ComboBox comboBoxAnStudiuUpdate;
        private System.Windows.Forms.Button buttonCancelAnStudiu;
        private System.Windows.Forms.Button ButtonUpdateAnStudiu;
        private System.Windows.Forms.TextBox textBoxAn_AnStudiu;
        private System.Windows.Forms.Label labelNumeProf;
    }
}