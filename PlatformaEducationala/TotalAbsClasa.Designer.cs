namespace PlatformaEducationala
{
    partial class TotalAbsClasa
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
            this.labelNrAbsCls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelVizAbs
            // 
            this.buttonCancelVizAbs.Location = new System.Drawing.Point(53, 79);
            this.buttonCancelVizAbs.Name = "buttonCancelVizAbs";
            this.buttonCancelVizAbs.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelVizAbs.TabIndex = 20;
            this.buttonCancelVizAbs.Text = "Cancel";
            this.buttonCancelVizAbs.UseVisualStyleBackColor = true;
            this.buttonCancelVizAbs.Click += new System.EventHandler(this.buttonCancelVizAbs_Click);
            // 
            // labelNrAbsCls
            // 
            this.labelNrAbsCls.AutoSize = true;
            this.labelNrAbsCls.Location = new System.Drawing.Point(50, 28);
            this.labelNrAbsCls.Name = "labelNrAbsCls";
            this.labelNrAbsCls.Size = new System.Drawing.Size(0, 13);
            this.labelNrAbsCls.TabIndex = 21;
            // 
            // TotalAbsClasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 142);
            this.Controls.Add(this.labelNrAbsCls);
            this.Controls.Add(this.buttonCancelVizAbs);
            this.Name = "TotalAbsClasa";
            this.Text = "VizualizareAbsClasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelVizAbs;
        private System.Windows.Forms.Label labelNrAbsCls;
    }
}