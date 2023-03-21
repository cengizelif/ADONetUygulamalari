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

namespace ADONetOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti=new SqlConnection();
            baglanti.ConnectionString = "server=203S-EGTMN;database=Northwind;Integrated Security=true";
            //    baglanti.ConnectionString= "server=203S-EGTMN;database=Northwind;user=sa;password=1234"
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Urunler";
            komut.Connection = baglanti;    
            baglanti.Open();
            SqlDataReader okunandata=komut.ExecuteReader();

            while (okunandata.Read()) 
            {
               string urunadi=okunandata["UrunAdi"].ToString();
               string fiyat=okunandata["BirimFiyati"].ToString();
               string stok = okunandata["HedefStokDuzeyi"].ToString();
               lst_urunler.Items.Add(urunadi+" "+fiyat+" "+stok);  
            }

            baglanti.Close();
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
                kf =(KategoriForm)Application.OpenForms["KategoriForm"];
                kf.Focus();
            }          
         
        }
    }
}
