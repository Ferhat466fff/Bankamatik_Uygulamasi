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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void btn_Giriş_Yap_Click(object sender, EventArgs e)
        {
            try
            {   if (string.IsNullOrWhiteSpace(msk_Hesap_No.Text) || string.IsNullOrWhiteSpace(txt_Sifre.Text))
                {
                    MessageBox.Show("Lütfen Tüm Alanları Eksiksiz doldurun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Kişiler where HESAPNO=@p1 and SIFRE=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", msk_Hesap_No.Text);
                komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);
                SqlDataReader dt = komut.ExecuteReader();
                if(dt.Read())
                {
                    Form2 fr = new Form2();
                    fr.hessap = msk_Hesap_No.Text;
                    fr.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı Kullanıcı adı Veya Şifre"+ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            finally
            {
                baglanti.Close();
            }
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
