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

namespace AirportInadRegister
{
    public partial class HavaYolları : Form
    {
        public HavaYolları()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=GudeInad;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand havayoluEkle = new SqlCommand("insert into Havayolu (HavayoluIsim) values (@p1)", baglanti);
                havayoluEkle.Parameters.AddWithValue("@p1", txtHavayoluName.Text);
                havayoluEkle.ExecuteNonQuery();
                this.havayoluTableAdapter1.Fill(this.gudeInadDataSet1.Havayolu);
                baglanti.Close();
                
                MessageBox.Show("Havayolu Eklenmiştir");
            }
            catch
            {
               
                MessageBox.Show("Hata..!!!");
            }
        }

        private void HavaYolları_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeInadDataSet1.Havayolu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havayoluTableAdapter1.Fill(this.gudeInadDataSet1.Havayolu);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from Havayolu where Id=@p1", baglanti);
                komut2.Parameters.AddWithValue(("@p1"), (txtHavayoluId.Text));
                komut2.ExecuteNonQuery();
                this.havayoluTableAdapter1.Fill(this.gudeInadDataSet1.Havayolu);
                baglanti.Close();
                MessageBox.Show("silindi");


            }

            catch
            {
                MessageBox.Show("Hata...");

            }
        }
    }
}
