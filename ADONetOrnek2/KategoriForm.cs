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
            //SqlDataAdapter adp = new SqlDataAdapter("select * from Kategoriler", baglanti);
            SqlDataAdapter adp = new SqlDataAdapter("KategoriListesi", baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv_kategoriler.DataSource = dt;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("KategoriEkle",baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            //komut.CommandText = string.Format("insert into Kategoriler (KategoriAdi,Tanimi) values('{0}','{1}')", txt_katad.Text,txt_tanim.Text);

            //komut.CommandText = "insert into Kategoriler(KategoriAdi,Tanimi) values(@katAd,@tanim)";
            //komut.Connection = baglanti;

            komut.Parameters.AddWithValue("@katAd", txt_katad.Text);
            komut.Parameters.AddWithValue("@tanim", txt_tanim.Text);

            baglanti.Open();
            try
            {
                int sonuc = komut.ExecuteNonQuery();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            baglanti.Close();

        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            KategoriListele();          
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kategoriler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_kategoriler.CurrentRow.Cells["KategoriID"].Value);
                //SqlCommand komut = new SqlCommand();
                //komut.CommandText = string.Format("delete Kategoriler where KategoriID={0}", id);
                //komut.Connection = baglanti;
                SqlCommand komut=new SqlCommand("KategoriSil",baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@kId", id);

                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt silme başarılı");
                    KategoriListele();
                }
                else
                {
                    MessageBox.Show("Kayıt silem işlemi sırasında hata oluştu.");
                }
                baglanti.Close();
            }
        }

        private void dgv_kategoriler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32(dgv_kategoriler.CurrentRow.Cells["KategoriID"].Value);
            string kad = dgv_kategoriler.CurrentRow.Cells["KategoriAdi"].Value.ToString();
            string tanim = dgv_kategoriler.CurrentRow.Cells["Tanimi"].Value.ToString();

            SqlCommand komut = new SqlCommand("KategoriGuncelle",baglanti);
            komut.CommandType= CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kId",id);
            komut.Parameters.AddWithValue("@kAd",kad);
            komut.Parameters.AddWithValue("@tanim",tanim);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
