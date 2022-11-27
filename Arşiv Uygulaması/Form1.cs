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

namespace Arşiv_Uygulaması
{
    public partial class giris_ekrani : Form
    {
        public giris_ekrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302";
            var con1 = new SqlConnection(connectstring);
            
        }

        private void karsilama_mesaji_Click(object sender, EventArgs e)
        {

        }

        private void giris_butonu_Click(object sender, EventArgs e)
        {
            if (kullaniciadi.Text== "ishakersin" && sifre.Text== "1998Fenerbahce")
            {
                yukleme_ekrani form4 = new yukleme_ekrani();
                form4.Show();
                this.Hide();
              
            }
            else if (kullaniciadi.Text != "ishakersin" && sifre.Text != "1998Fenerbahce")
            {
                MessageBox.Show("Kullanıcı Adı Ve Şifreniz Hatalı");
            }
            else if (kullaniciadi.Text == "ishakersin" && sifre.Text != "1998Fenerbahce")
            {
                MessageBox.Show("Kullanıcı Adı Doğru Fakat Şifreniz Hatalı");
            }
            else if (kullaniciadi.Text != "ishakersin" && sifre.Text == "1998Fenerbahce")
            {
                MessageBox.Show("Şifreniz Doğru Fakat Kullanıcı Adınız Hatalı");
            }           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cikis_butonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
