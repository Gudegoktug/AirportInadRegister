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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HAKEMF4;Initial Catalog=CelebiInad;Integrated Security=True");

        private void MainPage_Load(object sender, EventArgs e)
        {
          timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btnInadKayit_Click(object sender, EventArgs e)
        {
            InadRegister ınadRegister = new InadRegister();
            ınadRegister.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inad ınad = new Inad();
            ınad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InadSebep ınadSebep = new InadSebep();
            ınadSebep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HavaYolları havaYolları = new HavaYolları();
            havaYolları.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calısanlar calısanlar = new Calısanlar();
            calısanlar.ShowDialog();
        }
    }
}
