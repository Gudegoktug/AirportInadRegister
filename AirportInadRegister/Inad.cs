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
    public partial class Inad : Form
    {
        public Inad()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=GudeInad;Integrated Security=True");

        private void btnInadSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete InadYolcu where Id=@p1", baglanti);
                komut2.Parameters.AddWithValue(("@p1"), (txtInadId.Text));
                komut2.ExecuteNonQuery();
                this.inadYolcuTableAdapter.Fill(this.celebiInadDataSet5.InadYolcu);
                this.inadYolcuTableAdapter1.Fill(this.gudeInadDataSet3.InadYolcu);
                baglanti.Close();
                MessageBox.Show("silindi");
                

            }

            catch
            {
                MessageBox.Show("Hata...");

            }
        }

        private void Inad_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gudeInadDataSet3.InadYolcu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.inadYolcuTableAdapter1.Fill(this.gudeInadDataSet3.InadYolcu);
            // TODO: Bu kod satırı 'celebiInadDataSet5.InadYolcu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.inadYolcuTableAdapter.Fill(this.celebiInadDataSet5.InadYolcu);

        }
    }
}
