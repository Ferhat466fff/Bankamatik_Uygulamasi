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
using System.Data.SqlClient;

namespace Bankamatik_Simülasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=DbBankaTest;Integrated Security=True");
        public string hessap;
        private void Form2_Load(object sender, EventArgs e)
        {   //Hesap no taşıma(form1 işlem var)
            lbl_Hesap_NO.Text = hessap;

            //Hesap No'ya Göre Bilgileri getirme
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Kişiler where HESAPNO=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", lbl_Hesap_NO.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lbl_Ad_Soyad.Text = dr[1].ToString() + "" + dr[2].ToString();
                    lbl_TC.Text = dr[3].ToString();
                    lbl_Telefon.Text = dr[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message, "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btn_Gönder_Click(object sender, EventArgs e)
        {

            //Gönderilen Hesabın Para Artışı
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Hesap set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", decimal.Parse(txt_Tutar.Text));
                komut.Parameters.AddWithValue("@p2", msk_Hesap_No.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı veya eksik hesap no" + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }

            //Gönderen Hesabın parasının azalışı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update Tbl_Hesap set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut1.Parameters.AddWithValue("@k1", decimal.Parse(txt_Tutar.Text));
            komut1.Parameters.AddWithValue("@k2", hessap);
            komut1.ExecuteNonQuery();
            baglanti.Close();


            //Tbl_Haraket ilişkilendiridk lblhesap...
            baglanti.Open();
                SqlCommand komut2 = new SqlCommand("INSERT INTO Tbl_Haraket (GONDEREN, ALICI, TUTAR) VALUES (@t1, @t2, @t3)", baglanti);
                komut2.Parameters.AddWithValue("@t1", lbl_Hesap_NO.Text);
                komut2.Parameters.AddWithValue("@t2", msk_Hesap_No.Text);
                komut2.Parameters.AddWithValue("@t3", decimal.Parse(txt_Tutar.Text));

                komut2.ExecuteNonQuery();
            baglanti.Close();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
