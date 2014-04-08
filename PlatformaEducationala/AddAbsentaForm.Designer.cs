namespace PlatformaEducationala
{
    partial class AddAbsentaForm
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
            this.textBoxAddAbsMotivata = new System.Windows.Forms.TextBox();
            this.textBoxAddAbsMotivabila = new System.Windows.Forms.TextBox();
            this.buttonAddAbsForm = new System.Windows.Forms.Button();
            this.buttonAddAbsentaFormCncel = new System.Windows.Forms.Button();
            this.labelMsgAddAbsentaForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivata ( true - daca introduceti o absenta motivata , false - pentru abesenta n" +
    "emotivata ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motivabila ( true - daca permiteti motivarea absentei, false - in caz contrar ):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data absentei va fi cea de azi!";
            // 
            // textBoxAddAbsMotivata
            // 
            this.textBoxAddAbsMotivata.Location = new System.Drawing.Point(64, 82);
            this.textBoxAddAbsMotivata.Name = "textBoxAddAbsMotivata";
            this.textBoxAddAbsMotivata.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddAbsMotivata.TabIndex = 3;
            // 
            // textBoxAddAbsMotivabila
            // 
            this.textBoxAddAbsMotivabila.Location = new System.Drawing.Point(64, 181);
            this.textBoxAddAbsMotivabila.Name = "textBoxAddAbsMotivabila";
            this.textBoxAddAbsMotivabila.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddAbsMotivabila.TabIndex = 4;
            // 
            // buttonAddAbsForm
            // 
            this.buttonAddAbsForm.Location = new System.Drawing.Point(287, 210);
            this.buttonAddAbsForm.Name = "buttonAddAbsForm";
            this.buttonAddAbsForm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAbsForm.TabIndex = 5;
            this.buttonAddAbsForm.Text = "Add";
            this.buttonAddAbsForm.UseVisualStyleBackColor = true;
            this.buttonAddAbsForm.Click += new System.EventHandler(this.buttonAddAbsForm_Click);
            // 
            // buttonAddAbsentaFormCncel
            // 
            this.buttonAddAbsentaFormCncel.Location = new System.Drawing.Point(380, 211);
            this.buttonAddAbsentaFormCncel.Name = "buttonAddAbsentaFormCncel";
            this.buttonAddAbsentaFormCncel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAbsentaFormCncel.TabIndex = 6;
            this.buttonAddAbsentaFormCncel.Text = "Cancel";
            this.buttonAddAbsentaFormCncel.UseVisualStyleBackColor = true;
            this.buttonAddAbsentaFormCncel.Click += new System.EventHandler(this.buttonAddAbsentaFormCncel_Click);
            // 
            // labelMsgAddAbsentaForm
            // 
            this.labelMsgAddAbsentaForm.AutoSize = true;
            this.labelMsgAddAbsentaForm.Location = new System.Drawing.Point(34, 220);
            this.labelMsgAddAbsentaForm.Name = "labelMsgAddAbsentaForm";
            this.labelMsgAddAbsentaForm.Size = new System.Drawing.Size(0, 13);
            this.labelMsgAddAbsentaForm.TabIndex = 7;
            // 
            // AddAbsentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 262);
            this.Controls.Add(this.labelMsgAddAbsentaForm);
            this.Controls.Add(this.buttonAddAbsentaFormCncel);
            this.Controls.Add(this.buttonAddAbsForm);
            this.Controls.Add(this.textBoxAddAbsMotivabila);
            this.Controls.Add(this.textBoxAddAbsMotivata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAbsentaForm";
            this.Text = "AddAbsentaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddAbsMotivata;
        private System.Windows.Forms.TextBox textBoxAddAbsMotivabila;
        private System.Windows.Forms.Button buttonAddAbsForm;
        private System.Windows.Forms.Button buttonAddAbsentaFormCncel;
        private System.Windows.Forms.Label labelMsgAddAbsentaForm;
    }
}