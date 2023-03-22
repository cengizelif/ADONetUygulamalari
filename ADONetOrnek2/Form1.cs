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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=203S-EGTMN;database=Northwind;Integrated Security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void UrunListele()
        {
            //Disconnected mimari
            SqlDataAdapter adp = new SqlDataAdapter("select * from Urunler where Sonlandi=0", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dgv_urunler.DataSource = dt;
            dgv_urunler.Columns["UrunID"].Visible = false;
            dgv_urunler.Columns["TedarikciID"].Visible = false;
            dgv_urunler.Columns["KategoriID"].Visible = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string urunad = txt_urunad.Text;
            decimal fiyat = nud_fiyat.Value;
            decimal stok = nud_stok.Value;

            if(urunad=="" || fiyat==0 ||stok==0)
            {
                MessageBox.Show("Ürün bilgileri boş geçilemez.");
            }
            else
            {
                SqlCommand komut = new SqlCommand();
                //komut.CommandText = string.Format("insert into Urunler (UrunAdi,BirimFiyati,HedefStokDuzeyi)     values('{0}',{1},{2})", urunad, fiyat, stok);

                komut.CommandText = "insert into Urunler (UrunAdi,BirimFiyati,HedefStokDuzeyi)     values(@urunAdi,@fiyat,@stok)";
                komut.Parameters.AddWithValue("@urunAdi", urunad);
                komut.Parameters.AddWithValue("@fiyat", fiyat);
                komut.Parameters.AddWithValue("@stok", stok);

                komut.Connection = baglanti;

                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı");
                    UrunListele();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi sırasında hata oluştu.");
                }

            }


        }

        private void btn_kategoriler_Click(object sender, EventArgs e)
        {
            KategoriForm kf;
            if (Application.OpenForms["KategoriForm"]==null)
            {
                kf=new KategoriForm();
                kf.Show();
            }
            else
            {
                kf = (KategoriForm)Application.OpenForms["KategoriForm"];
                kf.Focus();
            }
        }
      
        private void dgv_urunler_Click(object sender, EventArgs e)
        {
            txt_urunad.Text = dgv_urunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
            nud_fiyat.Value =(decimal)dgv_urunler.CurrentRow.Cells["BirimFiyati"].Value;
            nud_stok.Value =Convert.ToInt16(dgv_urunler.CurrentRow.Cells["HedefStokDuzeyi"].Value);
            txt_urunad.Tag=dgv_urunler.CurrentRow.Cells["UrunID"].Value;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string fiyat = nud_fiyat.Value.ToString().Replace(',', '.');
       
            SqlCommand komut = new SqlCommand();
            //komut.CommandText =string.Format("update Urunler set UrunAdi='{0}' ,BirimFiyati={1} ,HedefStokDuzeyi={2}  where UrunID={3}",txt_urunad.Text,fiyat,nud_stok.Value,txt_urunad.Tag);


            //komut.CommandText ="update Urunler set UrunAdi=@urunAd ,BirimFiyati=@fiyat ,HedefStokDuzeyi=@stok where UrunID=@id");

            komut.Parameters.AddWithValue("@urunAd", txt_urunad.Text);

            komut.Connection = baglanti;
            baglanti.Open();
            int sonuc=komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt güncelleme başarılı");
                UrunListele();
            }
            else
            {
                MessageBox.Show("Kayıt güncelleme işlemi sırasında hata oluştu.");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(dgv_urunler.CurrentRow.Cells["UrunID"].Value);

            
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText =string.Format("delete Urunler where UrunID={0}",id);
            //cmd.Connection = baglanti;

            //StoreProcedure ile ürün silme
            SqlCommand cmd=new SqlCommand("UrunSil", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urunId",id);

            baglanti.Open();
            int sonuc=cmd.ExecuteNonQuery();
            baglanti.Close();

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt silindi");
                UrunListele();
            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi sırasında hata oluştu.");
            }

        }

        private void dgv_urunler_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgv_urunler_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Delete)
            {
                int id = Convert.ToInt32(dgv_urunler.CurrentRow.Cells["UrunID"].Value);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("delete Urunler where UrunID={0}", id);
                cmd.Connection = baglanti;
                baglanti.Open();
                int sonuc = cmd.ExecuteNonQuery();
                baglanti.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt silindi");
                    UrunListele();
                }
                else
                {
                    MessageBox.Show("Kayıt silme işlemi sırasında hata oluştu.");
                }
            }
        }

        private void btn_SPEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("UrunEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunAdi",txt_urunad.Text);
            komut.Parameters.AddWithValue("@fiyat", nud_fiyat.Value);
            komut.Parameters.AddWithValue("@stok", nud_stok.Value);

            baglanti.Open();
            int sonuc=komut.ExecuteNonQuery();
            baglanti.Close();

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt ekleme başarılı");
                UrunListele();
            }
            else
            {
                MessageBox.Show("Kayıt eklem sırasında hata oluştu.");
            }
        }
    }
}
