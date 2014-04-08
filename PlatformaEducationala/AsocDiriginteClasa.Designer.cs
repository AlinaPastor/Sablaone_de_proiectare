namespace PlatformaEducationala
{
    partial class AsocDiriginteClasa
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
            this.buttonCancelAsocClasaDirig = new System.Windows.Forms.Button();
            this.buttonAsociereClasaDirig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProfiAsoc = new System.Windows.Forms.ComboBox();
            this.comboBoxClaseAsoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancelAsocClasaDirig
            // 
            this.buttonCancelAsocClasaDirig.Location = new System.Drawing.Point(272, 189);
            this.buttonCancelAsocClasaDirig.Name = "buttonCancelAsocClasaDirig";
            this.buttonCancelAsocClasaDirig.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAsocClasaDirig.TabIndex = 11;
            this.buttonCancelAsocClasaDirig.Text = "Cancel";
            this.buttonCancelAsocClasaDirig.UseVisualStyleBackColor = true;
            this.buttonCancelAsocClasaDirig.Click += new System.EventHandler(this.buttonCancelAsocClasaDirig_Click);
            // 
            // buttonAsociereClasaDirig
            // 
            this.buttonAsociereClasaDirig.Location = new System.Drawing.Point(157, 189);
            this.buttonAsociereClasaDirig.Name = "buttonAsociereClasaDirig";
            this.buttonAsociereClasaDirig.Size = new System.Drawing.Size(75, 23);
            this.buttonAsociereClasaDirig.TabIndex = 10;
            this.buttonAsociereClasaDirig.Text = "Asociere";
            this.buttonAsociereClasaDirig.UseVisualStyleBackColor = true;
            this.buttonAsociereClasaDirig.Click += new System.EventHandler(this.buttonAsociereClasaDirig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Profesori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clase:";
            // 
            // comboBoxProfiAsoc
            // 
            this.comboBoxProfiAsoc.FormattingEnabled = true;
            this.comboBoxProfiAsoc.Location = new System.Drawing.Point(281, 95);
            this.comboBoxProfiAsoc.Name = "comboBoxProfiAsoc";
            this.comboBoxProfiAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfiAsoc.TabIndex = 7;
            // 
            // comboBoxClaseAsoc
            // 
            this.comboBoxClaseAsoc.FormattingEnabled = true;
            this.comboBoxClaseAsoc.Location = new System.Drawing.Point(44, 95);
            this.comboBoxClaseAsoc.Name = "comboBoxClaseAsoc";
            this.comboBoxClaseAsoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClaseAsoc.TabIndex = 6;
            // 
            // AsocDiriginteClasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 304);
            this.Controls.Add(this.buttonCancelAsocClasaDirig);
            this.Controls.Add(this.buttonAsociereClasaDirig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProfiAsoc);
            this.Controls.Add(this.comboBoxClaseAsoc);
            this.Name = "AsocDiriginteClasa";
            this.Text = "AsocDiriginteClasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAsocClasaDirig;
        private System.Windows.Forms.Button buttonAsociereClasaDirig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProfiAsoc;
        private System.Windows.Forms.ComboBox comboBoxClaseAsoc;
    }
}