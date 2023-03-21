namespace ADONetOrnek2
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
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_urunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_kategoriler = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Location = new System.Drawing.Point(24, 65);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_urunler.Size = new System.Drawing.Size(776, 302);
            this.dgv_urunler.TabIndex = 5;
            this.dgv_urunler.Click += new System.EventHandler(this.dgv_urunler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // txt_urunad
            // 
            this.txt_urunad.Location = new System.Drawing.Point(71, 24);
            this.txt_urunad.Name = "txt_urunad";
            this.txt_urunad.Size = new System.Drawing.Size(139, 20);
            this.txt_urunad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat";
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.Location = new System.Drawing.Point(251, 24);
            this.nud_fiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(120, 20);
            this.nud_fiyat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok";
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(412, 25);
            this.nud_stok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(120, 20);
            this.nud_stok.TabIndex = 2;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(538, 22);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(68, 23);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_kategoriler
            // 
            this.btn_kategoriler.Location = new System.Drawing.Point(709, 22);
            this.btn_kategoriler.Name = "btn_kategoriler";
            this.btn_kategoriler.Size = new System.Drawing.Size(91, 23);
            this.btn_kategoriler.TabIndex = 4;
            this.btn_kategoriler.Text = "Kategoriler";
            this.btn_kategoriler.UseVisualStyleBackColor = true;
            this.btn_kategoriler.Click += new System.EventHandler(this.btn_kategoriler_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(612, 22);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(91, 23);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 389);
            this.Controls.Add(this.btn_kategoriler);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.nud_stok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_fiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_urunad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_urunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_urunad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_kategoriler;
        private System.Windows.Forms.Button btn_guncelle;
    }
}

