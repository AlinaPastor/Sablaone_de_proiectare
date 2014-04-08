namespace PlatformaEducationala
{
    partial class AsocClasaElev
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
            this.comboBoxClaseAsoc = new System.Windows.Forms.ComboBox();
            this.comboBoxEleviAsoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAsociereClasaElev = new System.Windows.Forms.Button();
            this.buttonCancelAsocClasaElev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxClaseAsoc
            // 
            this.comboBoxClaseAsoc.FormattingEnabled = true;
            this.comboBoxClaseAsoc.Location = new System.Drawing.Point(65, 50);
            this.comboBoxClaseAsoc.Name = "comboBoxClaseAsoc";
            this.comboBoxClaseAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClaseAsoc.TabIndex = 0;
            this.comboBoxClaseAsoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxClaseAsoc_SelectedIndexChanged);
            // 
            // comboBoxEleviAsoc
            // 
            this.comboBoxEleviAsoc.FormattingEnabled = true;
            this.comboBoxEleviAsoc.Location = new System.Drawing.Point(302, 50);
            this.comboBoxEleviAsoc.Name = "comboBoxEleviAsoc";
            this.comboBoxEleviAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEleviAsoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elevi:";
            // 
            // buttonAsociereClasaElev
            // 
            this.buttonAsociereClasaElev.Location = new System.Drawing.Point(180, 143);
            this.buttonAsociereClasaElev.Name = "buttonAsociereClasaElev";
            this.buttonAsociereClasaElev.Size = new System.Drawing.Size(75, 23);
            this.buttonAsociereClasaElev.TabIndex = 4;
            this.buttonAsociereClasaElev.Text = "Asociere";
            this.buttonAsociereClasaElev.UseVisualStyleBackColor = true;
            this.buttonAsociereClasaElev.Click += new System.EventHandler(this.buttonAsociereClasaElev_Click);
            // 
            // buttonCancelAsocClasaElev
            // 
            this.buttonCancelAsocClasaElev.Location = new System.Drawing.Point(292, 143);
            this.buttonCancelAsocClasaElev.Name = "buttonCancelAsocClasaElev";
            this.buttonCancelAsocClasaElev.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAsocClasaElev.TabIndex = 5;
            this.buttonCancelAsocClasaElev.Text = "Cancel";
            this.buttonCancelAsocClasaElev.UseVisualStyleBackColor = true;
            this.buttonCancelAsocClasaElev.Click += new System.EventHandler(this.buttonCancelAsocClasaElev_Click);
            // 
            // AsocClasaElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 262);
            this.Controls.Add(this.buttonCancelAsocClasaElev);
            this.Controls.Add(this.buttonAsociereClasaElev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEleviAsoc);
            this.Controls.Add(this.comboBoxClaseAsoc);
            this.Name = "AsocClasaElev";
            this.Text = "AsocClasaElev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClaseAsoc;
        private System.Windows.Forms.ComboBox comboBoxEleviAsoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAsociereClasaElev;
        private System.Windows.Forms.Button buttonCancelAsocClasaElev;
    }
}