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

namespace AirportInadRegister
{
    public partial class Calısanlar : Form
    {
        public Calısanlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=GudeInad;Integrated Security=True");
        private void Calısanlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeInadDataSet11.Calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTableAdapter1.Fill(this.gudeInadDataSet11.Calisan);
            

        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand calisanEkle = new SqlCommand("insert into Calisan (Isim,Soyisim,GirisTarihi,TelefonNumarasý) values (@p1,@p2,@p3,@p4)", baglanti);
            calisanEkle.Parameters.AddWithValue("@p1" , txtCalisanName.Text);
            calisanEkle.Parameters.AddWithValue("@p2" , txtCalisanSurName.Text);
            calisanEkle.Parameters.AddWithValue("@p3" , mskCalisanDogum.Text);
            calisanEkle.Parameters.AddWithValue("@p4" , mskCalisanTel.Text);
            calisanEkle.ExecuteNonQuery();
            this.calisanTableAdapter1.Fill(this.gudeInadDataSet11.Calisan);
            MessageBox.Show("Başarı Eklendi");

        }
    }
}
