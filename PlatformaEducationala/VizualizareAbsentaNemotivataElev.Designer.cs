namespace PlatformaEducationala
{
    partial class VizualizareAbsentaNemotivataElev
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
            this.buttonCancelVizAbs = new System.Windows.Forms.Button();
            this.listBoxAbsenteVizualizare = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCancelVizAbs
            // 
            this.buttonCancelVizAbs.Location = new System.Drawing.Point(90, 231);
            this.buttonCancelVizAbs.Name = "buttonCancelVizAbs";
            this.buttonCancelVizAbs.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelVizAbs.TabIndex = 22;
            this.buttonCancelVizAbs.Text = "Cancel";
            this.buttonCancelVizAbs.UseVisualStyleBackColor = true;
            this.buttonCancelVizAbs.Click += new System.EventHandler(this.buttonCancelVizAbs_Click);
            // 
            // listBoxAbsenteVizualizare
            // 
            this.listBoxAbsenteVizualizare.FormattingEnabled = true;
            this.listBoxAbsenteVizualizare.Location = new System.Drawing.Point(11, 54);
            this.listBoxAbsenteVizualizare.Name = "listBoxAbsenteVizualizare";
            this.listBoxAbsenteVizualizare.Size = new System.Drawing.Size(323, 160);
            this.listBoxAbsenteVizualizare.TabIndex = 21;
            // 
            // VizualizareAbsentaNemotivataElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 308);
            this.Controls.Add(this.buttonCancelVizAbs);
            this.Controls.Add(this.listBoxAbsenteVizualizare);
            this.Name = "VizualizareAbsentaNemotivataElev";
            this.Text = "VizualizareAbsentaNemotivataElev";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelVizAbs;
        private System.Windows.Forms.ListBox listBoxAbsenteVizualizare;
    }
}