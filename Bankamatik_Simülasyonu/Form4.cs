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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=monster;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            
                baglanti.Open();

                // Tbl_Hareket tablosundan veriyi çek /select * from tblharaketlerin ınner joınlısı iste)
                SqlCommand Komut = new SqlCommand("SELECT k.AD AS 'Gönderen', h.ALICI, h.TUTAR\r\nFROM Tbl_Haraket h\r\nINNER JOIN Tbl_Kişiler k ON h.ID = k.ID", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(Komut);
                DataTable dt= new DataTable();
                da.Fill(dt);

                // Veriyi DataGridView'e aktar
                dataGridView1.DataSource = dt;
            baglanti.Close();
            

        }
    }
}
