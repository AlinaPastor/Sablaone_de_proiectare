namespace PlatformaEducationala
{
    partial class AddMaterie
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
            this.labelMsgAddMaterie = new System.Windows.Forms.Label();
            this.buttonCancelMaterie = new System.Windows.Forms.Button();
            this.buttonAddMaterie = new System.Windows.Forms.Button();
            this.textBoxMaterieNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMsgAddMaterie
            // 
            this.labelMsgAddMaterie.AutoSize = true;
            this.labelMsgAddMaterie.Location = new System.Drawing.Point(94, 148);
            this.labelMsgAddMaterie.Name = "labelMsgAddMaterie";
            this.labelMsgAddMaterie.Size = new System.Drawing.Size(0, 13);
            this.labelMsgAddMaterie.TabIndex = 9;
            // 
            // buttonCancelMaterie
            // 
            this.buttonCancelMaterie.Location = new System.Drawing.Point(189, 91);
            this.buttonCancelMaterie.Name = "buttonCancelMaterie";
            this.buttonCancelMaterie.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelMaterie.TabIndex = 8;
            this.buttonCancelMaterie.Text = "Cancel";
            this.buttonCancelMaterie.UseVisualStyleBackColor = true;
            this.buttonCancelMaterie.Click += new System.EventHandler(this.buttonCancelMaterie_Click);
            // 
            // buttonAddMaterie
            // 
            this.buttonAddMaterie.Location = new System.Drawing.Point(89, 91);
            this.buttonAddMaterie.Name = "buttonAddMaterie";
            this.buttonAddMaterie.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMaterie.TabIndex = 7;
            this.buttonAddMaterie.Text = "Add";
            this.buttonAddMaterie.UseVisualStyleBackColor = true;
            this.buttonAddMaterie.Click += new System.EventHandler(this.buttonAddMaterie_Click);
            // 
            // textBoxMaterieNume
            // 
            this.textBoxMaterieNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaterieNume.Location = new System.Drawing.Point(89, 36);
            this.textBoxMaterieNume.Name = "textBoxMaterieNume";
            this.textBoxMaterieNume.Size = new System.Drawing.Size(97, 13);
            this.textBoxMaterieNume.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume: ";
            // 
            // AddMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 202);
            this.Controls.Add(this.labelMsgAddMaterie);
            this.Controls.Add(this.buttonCancelMaterie);
            this.Controls.Add(this.buttonAddMaterie);
            this.Controls.Add(this.textBoxMaterieNume);
            this.Controls.Add(this.label1);
            this.Name = "AddMaterie";
            this.Text = "AddMaterie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsgAddMaterie;
        private System.Windows.Forms.Button buttonCancelMaterie;
        private System.Windows.Forms.Button buttonAddMaterie;
        private System.Windows.Forms.TextBox textBoxMaterieNume;
        private System.Windows.Forms.Label label1;
    }
}