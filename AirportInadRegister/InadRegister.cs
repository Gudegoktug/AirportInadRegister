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
    public partial class InadRegister : Form
    {
        public InadRegister()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=GudeInad;Integrated Security=True");
        
       

        private void btnInadKayit_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into InadYolcu (Isim,Soyisim,DogumYeri,Uyruk,GeldigiHavayolu,GeldigiTarih,UcusNo,GidecegiHavayolu,GidecegiTarih,GidecegiUcusNo,Neden,Refakat,BelgeNo,InadCinsiyet,GelisSaat,GidisSaat,DogumTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p13,@p14,@p15,@p16,@p17,@p18)", baglanti);
                //SqlCommand kayit = new SqlCommand("insert into InadYolcu (Isim,SoyIsim,DogumYeri,Uyruk,GeldigiTarih) values (@p1,@p2,@p3,@p4,@p6)", baglanti);
                kayit.Parameters.AddWithValue("@p1", txtName.Text);
                kayit.Parameters.AddWithValue("@p2", txtSurname.Text);
                kayit.Parameters.AddWithValue("@p3", cmbDogumYeri.SelectedItem).Value.ToString();
                kayit.Parameters.AddWithValue("@p4", cmbUyruk.SelectedItem).Value.ToString();
                kayit.Parameters.AddWithValue("@p5", cmbGelisHavayolu.SelectedValue).Value.ToString();
                kayit.Parameters.AddWithValue("@p6", mskGelisTarih.Text);
                kayit.Parameters.AddWithValue("@p7", txtGelisUcusNo.Text);
                kayit.Parameters.AddWithValue("@p8", cmbGidisHavayolu.SelectedValue).Value.ToString();
                kayit.Parameters.AddWithValue("@p9", mskGidisTarih.Text);
                kayit.Parameters.AddWithValue("@p10", txtGidisUcusNo.Text);
                kayit.Parameters.AddWithValue("@p11", cmbInadSebep.SelectedValue).Value.ToString();
                //kayit.Parameters.AddWithValue("@p12", (cmbBildirimAlan.SelectedIndex)).Value.ToString();
                kayit.Parameters.AddWithValue("@p13", txtRefakat.Text);
                kayit.Parameters.AddWithValue("@p14", txtBelgeNo.Text);
                if (rdoErkek.Checked)
                {
                    kayit.Parameters.AddWithValue("@p15", "erkek");
                }
                else
                {
                    kayit.Parameters.AddWithValue("@p15", "kadın");
                }
                kayit.Parameters.AddWithValue("@p16", mskGelisSaat.Text);
                kayit.Parameters.AddWithValue("@p17", mskGidisSaat.Text);
                kayit.Parameters.AddWithValue("@p18", mskDogumTarihi.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("Başarılı Kayıt");
                baglanti.Close();
            }
            catch
            {

                MessageBox.Show("HATA");
            }







        }

        private void InadRegister_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeInadDataSet15.Calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTableAdapter3.Fill(this.gudeInadDataSet15.Calisan);
            // TODO: Bu kod satırı 'gudeInadDataSet14.Havayolu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havayoluTableAdapter5.Fill(this.gudeInadDataSet14.Havayolu);
            // TODO: Bu kod satırı 'gudeInadDataSet13.Havayolu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.havayoluTableAdapter4.Fill(this.gudeInadDataSet13.Havayolu);
            // TODO: Bu kod satırı 'gudeInadDataSet12.InadSebep' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.inadSebepTableAdapter2.Fill(this.gudeInadDataSet12.InadSebep);



        }
    }
}
