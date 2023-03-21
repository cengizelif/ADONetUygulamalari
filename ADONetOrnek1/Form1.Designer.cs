namespace ADONetOrnek1
{
    partial class Form1
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
            this.lst_urunler = new System.Windows.Forms.ListBox();
            this.btn_kategoriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_urunler
            // 
            this.lst_urunler.FormattingEnabled = true;
            this.lst_urunler.Location = new System.Drawing.Point(43, 71);
            this.lst_urunler.Name = "lst_urunler";
            this.lst_urunler.Size = new System.Drawing.Size(646, 342);
            this.lst_urunler.TabIndex = 0;
            // 
            // btn_kategoriler
            // 
            this.btn_kategoriler.Location = new System.Drawing.Point(563, 33);
            this.btn_kategoriler.Name = "btn_kategoriler";
            this.btn_kategoriler.Size = new System.Drawing.Size(126, 32);
            this.btn_kategoriler.TabIndex = 1;
            this.btn_kategoriler.Text = "Kategoriler";
            this.btn_kategoriler.UseVisualStyleBackColor = true;
            this.btn_kategoriler.Click += new System.EventHandler(this.btn_kategoriler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.btn_kategoriler);
            this.Controls.Add(this.lst_urunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_urunler;
        private System.Windows.Forms.Button btn_kategoriler;
    }
}

