namespace PlatformaEducationala
{
    partial class AddElev
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddElev = new System.Windows.Forms.Button();
            this.buttonCancelElev = new System.Windows.Forms.Button();
            this.textBoxNumeElev = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeElev = new System.Windows.Forms.TextBox();
            this.textBoxUserElev = new System.Windows.Forms.TextBox();
            this.textBoxParolaElev = new System.Windows.Forms.TextBox();
            this.labelMsgElev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola ";
            // 
            // buttonAddElev
            // 
            this.buttonAddElev.Location = new System.Drawing.Point(29, 164);
            this.buttonAddElev.Name = "buttonAddElev";
            this.buttonAddElev.Size = new System.Drawing.Size(75, 23);
            this.buttonAddElev.TabIndex = 4;
            this.buttonAddElev.Text = "Add";
            this.buttonAddElev.UseVisualStyleBackColor = true;
            this.buttonAddElev.Click += new System.EventHandler(this.buttonAddElev_Click);
            // 
            // buttonCancelElev
            // 
            this.buttonCancelElev.Location = new System.Drawing.Point(159, 163);
            this.buttonCancelElev.Name = "buttonCancelElev";
            this.buttonCancelElev.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelElev.TabIndex = 5;
            this.buttonCancelElev.Text = "Cancel";
            this.buttonCancelElev.UseVisualStyleBackColor = true;
            this.buttonCancelElev.Click += new System.EventHandler(this.buttonCancelElev_Click);
            // 
            // textBoxNumeElev
            // 
            this.textBoxNumeElev.Location = new System.Drawing.Point(102, 27);
            this.textBoxNumeElev.Name = "textBoxNumeElev";
            this.textBoxNumeElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeElev.TabIndex = 6;
            // 
            // textBoxPrenumeElev
            // 
            this.textBoxPrenumeElev.Location = new System.Drawing.Point(102, 56);
            this.textBoxPrenumeElev.Name = "textBoxPrenumeElev";
            this.textBoxPrenumeElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenumeElev.TabIndex = 7;
            // 
            // textBoxUserElev
            // 
            this.textBoxUserElev.Location = new System.Drawing.Point(102, 87);
            this.textBoxUserElev.Name = "textBoxUserElev";
            this.textBoxUserElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserElev.TabIndex = 8;
            // 
            // textBoxParolaElev
            // 
            this.textBoxParolaElev.Location = new System.Drawing.Point(102, 115);
            this.textBoxParolaElev.Name = "textBoxParolaElev";
            this.textBoxParolaElev.Size = new System.Drawing.Size(100, 20);
            this.textBoxParolaElev.TabIndex = 9;
            // 
            // labelMsgElev
            // 
            this.labelMsgElev.AutoSize = true;
            this.labelMsgElev.Location = new System.Drawing.Point(29, 209);
            this.labelMsgElev.Name = "labelMsgElev";
            this.labelMsgElev.Size = new System.Drawing.Size(0, 13);
            this.labelMsgElev.TabIndex = 10;
            // 
            // AddElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelMsgElev);
            this.Controls.Add(this.textBoxParolaElev);
            this.Controls.Add(this.textBoxUserElev);
            this.Controls.Add(this.textBoxPrenumeElev);
            this.Controls.Add(this.textBoxNumeElev);
            this.Controls.Add(this.buttonCancelElev);
            this.Controls.Add(this.buttonAddElev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddElev";
            this.Text = "AddElev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddElev;
        private System.Windows.Forms.Button buttonCancelElev;
        private System.Windows.Forms.TextBox textBoxNumeElev;
        private System.Windows.Forms.TextBox textBoxPrenumeElev;
        private System.Windows.Forms.TextBox textBoxUserElev;
        private System.Windows.Forms.TextBox textBoxParolaElev;
        private System.Windows.Forms.Label labelMsgElev;
    }
}