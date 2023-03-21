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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=203S-EGTMN;database=Northwind;Integrated Security=true");

            SqlCommand komut = new SqlCommand("select * from kategoriler", baglanti);
            
            baglanti.Open();
            SqlDataReader rdr=komut.ExecuteReader();

            while (rdr.Read()) 
            {
                string katAd = rdr["KategoriAdi"].ToString();
                string tanim = rdr["Tanimi"].ToString();
                lst_kategoriler.Items.Add(string.Format("{0},{1}", katAd, tanim));
            }
            baglanti.Close();
        }
    }
}
