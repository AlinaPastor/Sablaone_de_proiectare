namespace PlatformaEducationala
{
    partial class AddTezaForm
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
            this.labelMsgAddTezaForm = new System.Windows.Forms.Label();
            this.buttonAddTezaFormCncel = new System.Windows.Forms.Button();
            this.buttonAddTezaForm = new System.Windows.Forms.Button();
            this.textBoxAddTeza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMsgAddTezaForm
            // 
            this.labelMsgAddTezaForm.AutoSize = true;
            this.labelMsgAddTezaForm.Location = new System.Drawing.Point(31, 149);
            this.labelMsgAddTezaForm.Name = "labelMsgAddTezaForm";
            this.labelMsgAddTezaForm.Size = new System.Drawing.Size(0, 13);
            this.labelMsgAddTezaForm.TabIndex = 19;
            // 
            // buttonAddTezaFormCncel
            // 
            this.buttonAddTezaFormCncel.Location = new System.Drawing.Point(151, 99);
            this.buttonAddTezaFormCncel.Name = "buttonAddTezaFormCncel";
            this.buttonAddTezaFormCncel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTezaFormCncel.TabIndex = 18;
            this.buttonAddTezaFormCncel.Text = "Cancel";
            this.buttonAddTezaFormCncel.UseVisualStyleBackColor = true;
            this.buttonAddTezaFormCncel.Click += new System.EventHandler(this.buttonAddTezaFormCncel_Click);
            // 
            // buttonAddTezaForm
            // 
            this.buttonAddTezaForm.Location = new System.Drawing.Point(31, 99);
            this.buttonAddTezaForm.Name = "buttonAddTezaForm";
            this.buttonAddTezaForm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTezaForm.TabIndex = 17;
            this.buttonAddTezaForm.Text = "Add";
            this.buttonAddTezaForm.UseVisualStyleBackColor = true;
            this.buttonAddTezaForm.Click += new System.EventHandler(this.buttonAddTezaForm_Click);
            // 
            // textBoxAddTeza
            // 
            this.textBoxAddTeza.Location = new System.Drawing.Point(106, 40);
            this.textBoxAddTeza.Name = "textBoxAddTeza";
            this.textBoxAddTeza.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddTeza.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nota teza:";
            // 
            // AddTezaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelMsgAddTezaForm);
            this.Controls.Add(this.buttonAddTezaFormCncel);
            this.Controls.Add(this.buttonAddTezaForm);
            this.Controls.Add(this.textBoxAddTeza);
            this.Controls.Add(this.label1);
            this.Name = "AddTezaForm";
            this.Text = "AddTezaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsgAddTezaForm;
        private System.Windows.Forms.Button buttonAddTezaFormCncel;
        private System.Windows.Forms.Button buttonAddTezaForm;
        private System.Windows.Forms.TextBox textBoxAddTeza;
        private System.Windows.Forms.Label label1;
    }
}