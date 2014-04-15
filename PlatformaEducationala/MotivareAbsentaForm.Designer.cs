namespace PlatformaEducationala
{
    partial class MotivareAbsentaForm
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
            this.comboBoxListaAbsenteMotivare = new System.Windows.Forms.ComboBox();
            this.buttonMotiveazaAbsenta = new System.Windows.Forms.Button();
            this.buttonMotiveazaAbsentaCancel = new System.Windows.Forms.Button();
            this.labelMotivareAbsenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data: ";
            // 
            // comboBoxListaAbsenteMotivare
            // 
            this.comboBoxListaAbsenteMotivare.FormattingEnabled = true;
            this.comboBoxListaAbsenteMotivare.Location = new System.Drawing.Point(131, 30);
            this.comboBoxListaAbsenteMotivare.Name = "comboBoxListaAbsenteMotivare";
            this.comboBoxListaAbsenteMotivare.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListaAbsenteMotivare.TabIndex = 1;
            // 
            // buttonMotiveazaAbsenta
            // 
            this.buttonMotiveazaAbsenta.Location = new System.Drawing.Point(131, 106);
            this.buttonMotiveazaAbsenta.Name = "buttonMotiveazaAbsenta";
            this.buttonMotiveazaAbsenta.Size = new System.Drawing.Size(75, 23);
            this.buttonMotiveazaAbsenta.TabIndex = 2;
            this.buttonMotiveazaAbsenta.Text = "Motiveaza";
            this.buttonMotiveazaAbsenta.UseVisualStyleBackColor = true;
            this.buttonMotiveazaAbsenta.Click += new System.EventHandler(this.buttonMotiveazaAbsenta_Click);
            // 
            // buttonMotiveazaAbsentaCancel
            // 
            this.buttonMotiveazaAbsentaCancel.Location = new System.Drawing.Point(241, 106);
            this.buttonMotiveazaAbsentaCancel.Name = "buttonMotiveazaAbsentaCancel";
            this.buttonMotiveazaAbsentaCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonMotiveazaAbsentaCancel.TabIndex = 3;
            this.buttonMotiveazaAbsentaCancel.Text = "Cancel";
            this.buttonMotiveazaAbsentaCancel.UseVisualStyleBackColor = true;
            this.buttonMotiveazaAbsentaCancel.Click += new System.EventHandler(this.buttonMotiveazaAbsentaCancel_Click);
            // 
            // labelMotivareAbsenta
            // 
            this.labelMotivareAbsenta.AutoSize = true;
            this.labelMotivareAbsenta.Location = new System.Drawing.Point(37, 153);
            this.labelMotivareAbsenta.Name = "labelMotivareAbsenta";
            this.labelMotivareAbsenta.Size = new System.Drawing.Size(0, 13);
            this.labelMotivareAbsenta.TabIndex = 4;
            // 
            // MotivareAbsentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 208);
            this.Controls.Add(this.labelMotivareAbsenta);
            this.Controls.Add(this.buttonMotiveazaAbsentaCancel);
            this.Controls.Add(this.buttonMotiveazaAbsenta);
            this.Controls.Add(this.comboBoxListaAbsenteMotivare);
            this.Controls.Add(this.label1);
            this.Name = "MotivareAbsentaForm";
            this.Text = "MotivareAbsentaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListaAbsenteMotivare;
        private System.Windows.Forms.Button buttonMotiveazaAbsenta;
        private System.Windows.Forms.Button buttonMotiveazaAbsentaCancel;
        private System.Windows.Forms.Label labelMotivareAbsenta;
    }
}