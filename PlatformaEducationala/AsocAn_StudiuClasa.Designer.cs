namespace PlatformaEducationala
{
    partial class AsocAn_StudiuClasa
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
            this.buttonCancelAsocClasaAnStudiu = new System.Windows.Forms.Button();
            this.buttonAsociereClasaAnStudiu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAnStudiuAsoc = new System.Windows.Forms.ComboBox();
            this.comboBoxClaseAsoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancelAsocClasaAnStudiu
            // 
            this.buttonCancelAsocClasaAnStudiu.Location = new System.Drawing.Point(271, 188);
            this.buttonCancelAsocClasaAnStudiu.Name = "buttonCancelAsocClasaAnStudiu";
            this.buttonCancelAsocClasaAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAsocClasaAnStudiu.TabIndex = 17;
            this.buttonCancelAsocClasaAnStudiu.Text = "Cancel";
            this.buttonCancelAsocClasaAnStudiu.UseVisualStyleBackColor = true;
            this.buttonCancelAsocClasaAnStudiu.Click += new System.EventHandler(this.buttonCancelAsocClasaAnStudiu_Click);
            // 
            // buttonAsociereClasaAnStudiu
            // 
            this.buttonAsociereClasaAnStudiu.Location = new System.Drawing.Point(156, 188);
            this.buttonAsociereClasaAnStudiu.Name = "buttonAsociereClasaAnStudiu";
            this.buttonAsociereClasaAnStudiu.Size = new System.Drawing.Size(75, 23);
            this.buttonAsociereClasaAnStudiu.TabIndex = 16;
            this.buttonAsociereClasaAnStudiu.Text = "Asociere";
            this.buttonAsociereClasaAnStudiu.UseVisualStyleBackColor = true;
            this.buttonAsociereClasaAnStudiu.Click += new System.EventHandler(this.buttonAsociereClasaAnStudiu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ani scolari:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clase:";
            // 
            // comboBoxAnStudiuAsoc
            // 
            this.comboBoxAnStudiuAsoc.FormattingEnabled = true;
            this.comboBoxAnStudiuAsoc.Location = new System.Drawing.Point(280, 94);
            this.comboBoxAnStudiuAsoc.Name = "comboBoxAnStudiuAsoc";
            this.comboBoxAnStudiuAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnStudiuAsoc.TabIndex = 13;
            // 
            // comboBoxClaseAsoc
            // 
            this.comboBoxClaseAsoc.FormattingEnabled = true;
            this.comboBoxClaseAsoc.Location = new System.Drawing.Point(43, 94);
            this.comboBoxClaseAsoc.Name = "comboBoxClaseAsoc";
            this.comboBoxClaseAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClaseAsoc.TabIndex = 12;
            // 
            // AsocAn_StudiuClasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 320);
            this.Controls.Add(this.buttonCancelAsocClasaAnStudiu);
            this.Controls.Add(this.buttonAsociereClasaAnStudiu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAnStudiuAsoc);
            this.Controls.Add(this.comboBoxClaseAsoc);
            this.Name = "AsocAn_StudiuClasa";
            this.Text = "AsocAn_StudiuClasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAsocClasaAnStudiu;
        private System.Windows.Forms.Button buttonAsociereClasaAnStudiu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAnStudiuAsoc;
        private System.Windows.Forms.ComboBox comboBoxClaseAsoc;
    }
}