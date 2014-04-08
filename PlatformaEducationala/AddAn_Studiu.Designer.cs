namespace PlatformaEducationala
{
    partial class AddAn_Studiu
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
            this.labelMsgAddAnStudiu = new System.Windows.Forms.Label();
            this.buttonCancelAnStudiu = new System.Windows.Forms.Button();
            this.buttonAddAnStudiu = new System.Windows.Forms.Button();
            this.textBoxAddAnStudiu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMsgAddAnStudiu
            // 
            this.labelMsgAddAnStudiu.AutoSize = true;
            this.labelMsgAddAnStudiu.Location = new System.Drawing.Point(88, 147);
            this.labelMsgAddAnStudiu.Name = "labelMsgAddAnStudiu";
            this.labelMsgAddAnStudiu.Size = new System.Drawing.Size(0, 13);
            this.labelMsgAddAnStudiu.TabIndex = 9;
            // 
            // buttonCancelAnStudiu
            // 
            this.buttonCancelAnStudiu.Location = new System.Drawing.Point(183, 90);
            this.buttonCancelAnStudiu.Name = "buttonCancelAnStudiu";
            this.buttonCancelAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAnStudiu.TabIndex = 8;
            this.buttonCancelAnStudiu.Text = "Cancel";
            this.buttonCancelAnStudiu.UseVisualStyleBackColor = true;
            this.buttonCancelAnStudiu.Click += new System.EventHandler(this.buttonCancelAnStudiu_Click);
            // 
            // buttonAddAnStudiu
            // 
            this.buttonAddAnStudiu.Location = new System.Drawing.Point(83, 90);
            this.buttonAddAnStudiu.Name = "buttonAddAnStudiu";
            this.buttonAddAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAnStudiu.TabIndex = 7;
            this.buttonAddAnStudiu.Text = "Add";
            this.buttonAddAnStudiu.UseVisualStyleBackColor = true;
            this.buttonAddAnStudiu.Click += new System.EventHandler(this.buttonAddAnStudiu_Click);
            // 
            // textBoxAddAnStudiu
            // 
            this.textBoxAddAnStudiu.Location = new System.Drawing.Point(83, 32);
            this.textBoxAddAnStudiu.Name = "textBoxAddAnStudiu";
            this.textBoxAddAnStudiu.Size = new System.Drawing.Size(98, 20);
            this.textBoxAddAnStudiu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "An scolar: ";
            // 
            // AddAn_Studiu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.labelMsgAddAnStudiu);
            this.Controls.Add(this.buttonCancelAnStudiu);
            this.Controls.Add(this.buttonAddAnStudiu);
            this.Controls.Add(this.textBoxAddAnStudiu);
            this.Controls.Add(this.label1);
            this.Name = "AddAn_Studiu";
            this.Text = "AddAn_Studiu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsgAddAnStudiu;
        private System.Windows.Forms.Button buttonCancelAnStudiu;
        private System.Windows.Forms.Button buttonAddAnStudiu;
        private System.Windows.Forms.TextBox textBoxAddAnStudiu;
        private System.Windows.Forms.Label label1;
    }
}