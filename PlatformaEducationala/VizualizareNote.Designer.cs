namespace PlatformaEducationala
{
    partial class VizualizareNote
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
            this.buttonCancelVizNote = new System.Windows.Forms.Button();
            this.listBoxNoteVizualizare = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCancelVizNote
            // 
            this.buttonCancelVizNote.Location = new System.Drawing.Point(88, 221);
            this.buttonCancelVizNote.Name = "buttonCancelVizNote";
            this.buttonCancelVizNote.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelVizNote.TabIndex = 20;
            this.buttonCancelVizNote.Text = "Cancel";
            this.buttonCancelVizNote.UseVisualStyleBackColor = true;
            this.buttonCancelVizNote.Click += new System.EventHandler(this.buttonCancelVizNote_Click);
            // 
            // listBoxNoteVizualizare
            // 
            this.listBoxNoteVizualizare.FormattingEnabled = true;
            this.listBoxNoteVizualizare.Location = new System.Drawing.Point(9, 44);
            this.listBoxNoteVizualizare.Name = "listBoxNoteVizualizare";
            this.listBoxNoteVizualizare.Size = new System.Drawing.Size(323, 160);
            this.listBoxNoteVizualizare.TabIndex = 19;
            // 
            // VizualizareNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 289);
            this.Controls.Add(this.buttonCancelVizNote);
            this.Controls.Add(this.listBoxNoteVizualizare);
            this.Name = "VizualizareNote";
            this.Text = "VizualizareNote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelVizNote;
        private System.Windows.Forms.ListBox listBoxNoteVizualizare;
    }
}