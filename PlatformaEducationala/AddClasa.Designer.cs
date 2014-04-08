namespace PlatformaEducationala
{
    partial class AddClasa
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
            this.textBoxClasaNume = new System.Windows.Forms.TextBox();
            this.buttonAddClasa = new System.Windows.Forms.Button();
            this.buttonCancelClasa = new System.Windows.Forms.Button();
            this.labelMsgAddClasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume: ";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxClasaNume
            // 
            this.textBoxClasaNume.Location = new System.Drawing.Point(82, 25);
            this.textBoxClasaNume.Name = "textBoxClasaNume";
            this.textBoxClasaNume.Size = new System.Drawing.Size(98, 20);
            this.textBoxClasaNume.TabIndex = 1;
            //this.textBoxClasaNume.TextChanged += new System.EventHandler(this.textBoxClasaNume_TextChanged);
            // 
            // buttonAddClasa
            // 
            this.buttonAddClasa.Location = new System.Drawing.Point(82, 83);
            this.buttonAddClasa.Name = "buttonAddClasa";
            this.buttonAddClasa.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClasa.TabIndex = 2;
            this.buttonAddClasa.Text = "Add";
            this.buttonAddClasa.UseVisualStyleBackColor = true;
            this.buttonAddClasa.Click += new System.EventHandler(this.buttonAddClasa_Click);
            // 
            // buttonCancelClasa
            // 
            this.buttonCancelClasa.Location = new System.Drawing.Point(182, 83);
            this.buttonCancelClasa.Name = "buttonCancelClasa";
            this.buttonCancelClasa.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelClasa.TabIndex = 3;
            this.buttonCancelClasa.Text = "Cancel";
            this.buttonCancelClasa.UseVisualStyleBackColor = true;
            this.buttonCancelClasa.Click += new System.EventHandler(this.buttonCancelClasa_Click);
            // 
            // labelMsgAddClasa
            // 
            this.labelMsgAddClasa.AutoSize = true;
            this.labelMsgAddClasa.Location = new System.Drawing.Point(87, 140);
            this.labelMsgAddClasa.Name = "labelMsgAddClasa";
            this.labelMsgAddClasa.Size = new System.Drawing.Size(0, 13);
            this.labelMsgAddClasa.TabIndex = 4;
           // this.labelMsgAddClasa.Click += new System.EventHandler(this.labelMsgAddClasa_Click);
            // 
            // AddClasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.labelMsgAddClasa);
            this.Controls.Add(this.buttonCancelClasa);
            this.Controls.Add(this.buttonAddClasa);
            this.Controls.Add(this.textBoxClasaNume);
            this.Controls.Add(this.label1);
            this.Name = "AddClasa";
            this.Text = "AddClasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClasaNume;
        private System.Windows.Forms.Button buttonAddClasa;
        private System.Windows.Forms.Button buttonCancelClasa;
        private System.Windows.Forms.Label labelMsgAddClasa;
    }
}