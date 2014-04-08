namespace PlatformaEducationala
{
    partial class AddNotaForm
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
            this.labelMsgAddNotaForm = new System.Windows.Forms.Label();
            this.buttonAddAbsentaFormCncel = new System.Windows.Forms.Button();
            this.buttonAddAbsForm = new System.Windows.Forms.Button();
            this.textBoxAddNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMsgAddNotaForm
            // 
            this.labelMsgAddNotaForm.AutoSize = true;
            this.labelMsgAddNotaForm.Location = new System.Drawing.Point(38, 160);
            this.labelMsgAddNotaForm.Name = "labelMsgAddNotaForm";
            this.labelMsgAddNotaForm.Size = new System.Drawing.Size(0, 13);
            this.labelMsgAddNotaForm.TabIndex = 13;
            // 
            // buttonAddAbsentaFormCncel
            // 
            this.buttonAddAbsentaFormCncel.Location = new System.Drawing.Point(158, 110);
            this.buttonAddAbsentaFormCncel.Name = "buttonAddAbsentaFormCncel";
            this.buttonAddAbsentaFormCncel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAbsentaFormCncel.TabIndex = 12;
            this.buttonAddAbsentaFormCncel.Text = "Cancel";
            this.buttonAddAbsentaFormCncel.UseVisualStyleBackColor = true;
            this.buttonAddAbsentaFormCncel.Click += new System.EventHandler(this.buttonAddAbsentaFormCncel_Click);
            // 
            // buttonAddAbsForm
            // 
            this.buttonAddAbsForm.Location = new System.Drawing.Point(38, 110);
            this.buttonAddAbsForm.Name = "buttonAddAbsForm";
            this.buttonAddAbsForm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAbsForm.TabIndex = 11;
            this.buttonAddAbsForm.Text = "Add";
            this.buttonAddAbsForm.UseVisualStyleBackColor = true;
            this.buttonAddAbsForm.Click += new System.EventHandler(this.buttonAddAbsForm_Click);
            // 
            // textBoxAddNota
            // 
            this.textBoxAddNota.Location = new System.Drawing.Point(77, 51);
            this.textBoxAddNota.Name = "textBoxAddNota";
            this.textBoxAddNota.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddNota.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data notei va fi cea de azi!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nota:";
            // 
            // AddNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 206);
            this.Controls.Add(this.labelMsgAddNotaForm);
            this.Controls.Add(this.buttonAddAbsentaFormCncel);
            this.Controls.Add(this.buttonAddAbsForm);
            this.Controls.Add(this.textBoxAddNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddNotaForm";
            this.Text = "AddNotaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsgAddNotaForm;
        private System.Windows.Forms.Button buttonAddAbsentaFormCncel;
        private System.Windows.Forms.Button buttonAddAbsForm;
        private System.Windows.Forms.TextBox textBoxAddNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}