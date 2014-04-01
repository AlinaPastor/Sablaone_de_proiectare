namespace PlatformaEducationala
{
    partial class AbsentaForm
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
            this.comboBoxAbsentaSem = new System.Windows.Forms.ComboBox();
            this.comboBoxAbsentaMaterie = new System.Windows.Forms.ComboBox();
            this.comboBoxAbsentaElev = new System.Windows.Forms.ComboBox();
            this.buttonAbsentaVizualizare = new System.Windows.Forms.Button();
            this.buttonAddAbsenta = new System.Windows.Forms.Button();
            this.buttonMotivareAbsenta = new System.Windows.Forms.Button();
            this.buttonAbsentaCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAbsentaClasa = new System.Windows.Forms.ComboBox();
            this.labelEroareAbsentaForm = new System.Windows.Forms.Label();
            this.buttonVizAbsCls = new System.Windows.Forms.Button();
            this.buttonVizAbsClsNemoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semestru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elev:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Absente:";
            // 
            // comboBoxAbsentaSem
            // 
            this.comboBoxAbsentaSem.FormattingEnabled = true;
            this.comboBoxAbsentaSem.Location = new System.Drawing.Point(39, 52);
            this.comboBoxAbsentaSem.Name = "comboBoxAbsentaSem";
            this.comboBoxAbsentaSem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAbsentaSem.TabIndex = 4;
            // 
            // comboBoxAbsentaMaterie
            // 
            this.comboBoxAbsentaMaterie.FormattingEnabled = true;
            this.comboBoxAbsentaMaterie.Location = new System.Drawing.Point(207, 50);
            this.comboBoxAbsentaMaterie.Name = "comboBoxAbsentaMaterie";
            this.comboBoxAbsentaMaterie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAbsentaMaterie.TabIndex = 5;
            // 
            // comboBoxAbsentaElev
            // 
            this.comboBoxAbsentaElev.FormattingEnabled = true;
            this.comboBoxAbsentaElev.Location = new System.Drawing.Point(533, 51);
            this.comboBoxAbsentaElev.Name = "comboBoxAbsentaElev";
            this.comboBoxAbsentaElev.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAbsentaElev.TabIndex = 6;
            // 
            // buttonAbsentaVizualizare
            // 
            this.buttonAbsentaVizualizare.Location = new System.Drawing.Point(39, 139);
            this.buttonAbsentaVizualizare.Name = "buttonAbsentaVizualizare";
            this.buttonAbsentaVizualizare.Size = new System.Drawing.Size(75, 23);
            this.buttonAbsentaVizualizare.TabIndex = 7;
            this.buttonAbsentaVizualizare.Text = "Vizualizare";
            this.buttonAbsentaVizualizare.UseVisualStyleBackColor = true;
            this.buttonAbsentaVizualizare.Click += new System.EventHandler(this.buttonAbsentaVizualizare_Click);
            // 
            // buttonAddAbsenta
            // 
            this.buttonAddAbsenta.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonAddAbsenta.Location = new System.Drawing.Point(172, 141);
            this.buttonAddAbsenta.Name = "buttonAddAbsenta";
            this.buttonAddAbsenta.Size = new System.Drawing.Size(107, 22);
            this.buttonAddAbsenta.TabIndex = 10;
            this.buttonAddAbsenta.Text = "Adaugare";
            this.buttonAddAbsenta.UseVisualStyleBackColor = true;
            this.buttonAddAbsenta.UseWaitCursor = true;
            this.buttonAddAbsenta.Click += new System.EventHandler(this.buttonAddAbsenta_Click);
            // 
            // buttonMotivareAbsenta
            // 
            this.buttonMotivareAbsenta.Location = new System.Drawing.Point(329, 140);
            this.buttonMotivareAbsenta.Name = "buttonMotivareAbsenta";
            this.buttonMotivareAbsenta.Size = new System.Drawing.Size(75, 23);
            this.buttonMotivareAbsenta.TabIndex = 11;
            this.buttonMotivareAbsenta.Text = "Motivare";
            this.buttonMotivareAbsenta.UseVisualStyleBackColor = true;
            this.buttonMotivareAbsenta.Click += new System.EventHandler(this.buttonMotivareAbsenta_Click);
            // 
            // buttonAbsentaCancel
            // 
            this.buttonAbsentaCancel.Location = new System.Drawing.Point(499, 209);
            this.buttonAbsentaCancel.Name = "buttonAbsentaCancel";
            this.buttonAbsentaCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonAbsentaCancel.TabIndex = 12;
            this.buttonAbsentaCancel.Text = "Cancel";
            this.buttonAbsentaCancel.UseVisualStyleBackColor = true;
            this.buttonAbsentaCancel.Click += new System.EventHandler(this.buttonAbsentaCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clasa";
            // 
            // comboBoxAbsentaClasa
            // 
            this.comboBoxAbsentaClasa.FormattingEnabled = true;
            this.comboBoxAbsentaClasa.Location = new System.Drawing.Point(374, 50);
            this.comboBoxAbsentaClasa.Name = "comboBoxAbsentaClasa";
            this.comboBoxAbsentaClasa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAbsentaClasa.TabIndex = 14;
            // 
            // labelEroareAbsentaForm
            // 
            this.labelEroareAbsentaForm.AutoSize = true;
            this.labelEroareAbsentaForm.Location = new System.Drawing.Point(85, 219);
            this.labelEroareAbsentaForm.Name = "labelEroareAbsentaForm";
            this.labelEroareAbsentaForm.Size = new System.Drawing.Size(0, 13);
            this.labelEroareAbsentaForm.TabIndex = 15;
            // 
            // buttonVizAbsCls
            // 
            this.buttonVizAbsCls.Location = new System.Drawing.Point(432, 139);
            this.buttonVizAbsCls.Name = "buttonVizAbsCls";
            this.buttonVizAbsCls.Size = new System.Drawing.Size(75, 23);
            this.buttonVizAbsCls.TabIndex = 16;
            this.buttonVizAbsCls.Text = "VizAbsClasa";
            this.buttonVizAbsCls.UseVisualStyleBackColor = true;
            this.buttonVizAbsCls.Click += new System.EventHandler(this.buttonVizAbsCls_Click);
            // 
            // buttonVizAbsClsNemoti
            // 
            this.buttonVizAbsClsNemoti.Location = new System.Drawing.Point(524, 140);
            this.buttonVizAbsClsNemoti.Name = "buttonVizAbsClsNemoti";
            this.buttonVizAbsClsNemoti.Size = new System.Drawing.Size(130, 23);
            this.buttonVizAbsClsNemoti.TabIndex = 17;
            this.buttonVizAbsClsNemoti.Text = "VizAbsClasaNemotiv";
            this.buttonVizAbsClsNemoti.UseVisualStyleBackColor = true;
            this.buttonVizAbsClsNemoti.Click += new System.EventHandler(this.buttonVizAbsClsNemoti_Click);
            // 
            // AbsentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 262);
            this.Controls.Add(this.buttonVizAbsClsNemoti);
            this.Controls.Add(this.buttonVizAbsCls);
            this.Controls.Add(this.labelEroareAbsentaForm);
            this.Controls.Add(this.comboBoxAbsentaClasa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAbsentaCancel);
            this.Controls.Add(this.buttonMotivareAbsenta);
            this.Controls.Add(this.buttonAddAbsenta);
            this.Controls.Add(this.buttonAbsentaVizualizare);
            this.Controls.Add(this.comboBoxAbsentaElev);
            this.Controls.Add(this.comboBoxAbsentaMaterie);
            this.Controls.Add(this.comboBoxAbsentaSem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AbsentaForm";
            this.Text = "AbsentaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAbsentaSem;
        private System.Windows.Forms.ComboBox comboBoxAbsentaMaterie;
        private System.Windows.Forms.ComboBox comboBoxAbsentaElev;
        private System.Windows.Forms.Button buttonAbsentaVizualizare;
        private System.Windows.Forms.Button buttonAddAbsenta;
        private System.Windows.Forms.Button buttonMotivareAbsenta;
        private System.Windows.Forms.Button buttonAbsentaCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAbsentaClasa;
        private System.Windows.Forms.Label labelEroareAbsentaForm;
        private System.Windows.Forms.Button buttonVizAbsCls;
        private System.Windows.Forms.Button buttonVizAbsClsNemoti;
    }
}