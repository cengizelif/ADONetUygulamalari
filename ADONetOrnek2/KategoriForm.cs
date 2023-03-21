using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetOrnek2
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=203S-EGTMN;database=Northwind;Integrated Security=true");

        private void KategoriListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kategoriler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv_kategoriler.DataSource = dt;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("insert into Kategoriler (KategoriAdi,Tanimi)  values('{0}','{1}')", txt_katad.Text,txt_tanim.Text);

            komut.Connection = baglanti;

            baglanti.Open();
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt işlemi başarılı");
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Kayıt işlemi sırasında hata oluştu.");
            }
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }
    }
}
