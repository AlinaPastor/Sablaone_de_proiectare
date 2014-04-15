namespace PlatformaEducationala
{
    partial class DeleteMaterie
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
            this.labelDeleteMaterii = new System.Windows.Forms.Label();
            this.buttonCancelDeleteMaterie = new System.Windows.Forms.Button();
            this.buttonDeleteMaterie = new System.Windows.Forms.Button();
            this.comboBoxDeleteMaterii = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeleteMaterii
            // 
            this.labelDeleteMaterii.AutoSize = true;
            this.labelDeleteMaterii.Location = new System.Drawing.Point(79, 145);
            this.labelDeleteMaterii.Name = "labelDeleteMaterii";
            this.labelDeleteMaterii.Size = new System.Drawing.Size(0, 13);
            this.labelDeleteMaterii.TabIndex = 19;
            // 
            // buttonCancelDeleteMaterie
            // 
            this.buttonCancelDeleteMaterie.Location = new System.Drawing.Point(193, 99);
            this.buttonCancelDeleteMaterie.Name = "buttonCancelDeleteMaterie";
            this.buttonCancelDeleteMaterie.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelDeleteMaterie.TabIndex = 18;
            this.buttonCancelDeleteMaterie.Text = "Cancel";
            this.buttonCancelDeleteMaterie.UseVisualStyleBackColor = true;
            this.buttonCancelDeleteMaterie.Click += new System.EventHandler(this.buttonCancelDeleteMaterie_Click);
            // 
            // buttonDeleteMaterie
            // 
            this.buttonDeleteMaterie.Location = new System.Drawing.Point(79, 99);
            this.buttonDeleteMaterie.Name = "buttonDeleteMaterie";
            this.buttonDeleteMaterie.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMaterie.TabIndex = 17;
            this.buttonDeleteMaterie.Text = "Delete";
            this.buttonDeleteMaterie.UseVisualStyleBackColor = true;
            this.buttonDeleteMaterie.Click += new System.EventHandler(this.buttonDeleteMaterie_Click);
            // 
            // comboBoxDeleteMaterii
            // 
            this.comboBoxDeleteMaterii.FormattingEnabled = true;
            this.comboBoxDeleteMaterii.Location = new System.Drawing.Point(79, 39);
            this.comboBoxDeleteMaterii.Name = "comboBoxDeleteMaterii";
            this.comboBoxDeleteMaterii.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteMaterii.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Materii: ";
            // 
            // DeleteMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.labelDeleteMaterii);
            this.Controls.Add(this.buttonCancelDeleteMaterie);
            this.Controls.Add(this.buttonDeleteMaterie);
            this.Controls.Add(this.comboBoxDeleteMaterii);
            this.Controls.Add(this.label1);
            this.Name = "DeleteMaterie";
            this.Text = "DeleteMaterie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteMaterii;
        private System.Windows.Forms.Button buttonCancelDeleteMaterie;
        private System.Windows.Forms.Button buttonDeleteMaterie;
        private System.Windows.Forms.ComboBox comboBoxDeleteMaterii;
        private System.Windows.Forms.Label label1;
    }
}