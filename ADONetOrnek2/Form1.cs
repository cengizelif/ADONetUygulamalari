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
            SqlDataAdapter adp = new SqlDataAdapter("select * from Urunler", baglanti);
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
                komut.CommandText = string.Format("insert into Urunler (UrunAdi,BirimFiyati,HedefStokDuzeyi)     values('{0}',{1},{2})", urunad, fiyat, stok);

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
            komut.CommandText =string.Format("update Urunler set UrunAdi='{0}' ,BirimFiyati={1} ,HedefStokDuzeyi={2}  where UrunID={3}",txt_urunad.Text,fiyat,nud_stok.Value,txt_urunad.Tag);
           
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
    }
}
