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
    public partial class InadSebep : Form
    {
        public InadSebep()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=GudeInad;Integrated Security=True");
        private void InadSebep_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeInadDataSet9.InadSebep' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.inadSebepTableAdapter1.Fill(this.gudeInadDataSet9.InadSebep);
            // TODO: Bu kod satırı 'celebiInadDataSet7.InadSebep' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }

        private void btnInadSebepEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand ınadSebepSil = new SqlCommand("insert into InadSebep (Sebep) values (@p1)", baglanti);
                ınadSebepSil.Parameters.AddWithValue("@p1", txtInadSebepEkle.Text);
                ınadSebepSil.ExecuteNonQuery();
                MessageBox.Show("Başarılı Şekilde Eklendi.");
                this.inadSebepTableAdapter1.Fill(this.gudeInadDataSet9.InadSebep);
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata..!!");
                
            }
         

        }
    }
}
