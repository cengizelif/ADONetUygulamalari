namespace ADONetOrnek1
{
    partial class KategoriForm
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
            this.lst_kategoriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_kategoriler
            // 
            this.lst_kategoriler.FormattingEnabled = true;
            this.lst_kategoriler.Location = new System.Drawing.Point(57, 68);
            this.lst_kategoriler.Name = "lst_kategoriler";
            this.lst_kategoriler.Size = new System.Drawing.Size(637, 277);
            this.lst_kategoriler.TabIndex = 0;
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_kategoriler);
            this.Name = "KategoriForm";
            this.Text = "KategoriForm";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_kategoriler;
    }
}