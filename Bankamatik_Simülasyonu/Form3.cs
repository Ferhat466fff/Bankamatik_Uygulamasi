using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankamatik_Simülasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Ekleme
            try
            {
                baglanti.Open();
                if (string.IsNullOrWhiteSpace(txt_Ad.Text) || string.IsNullOrWhiteSpace(txt_Soyad.Text) || string.IsNullOrWhiteSpace(msk_TC.Text) || string.IsNullOrWhiteSpace(msk_Tel.Text) || string.IsNullOrWhiteSpace(msk_Hesap_No.Text) || string.IsNullOrWhiteSpace(txt_Sifre.Text))
                {//string.null veya bos gecilemeisn
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kişiler (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
                komut.Parameters.AddWithValue("@p3", msk_TC.Text);
                komut.Parameters.AddWithValue("@p4", msk_Tel.Text);
                komut.Parameters.AddWithValue("@p5", msk_Hesap_No.Text);
                komut.Parameters.AddWithValue("@p6", txt_Sifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme İşlemi yapıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata"+ex.Message,"uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int sayi = rast.Next(100000, 1000000);
            msk_Hesap_No.Text = sayi.ToString();
          

        }
    }
}
