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
    public partial class islem_ekranı : Form
    {
        public islem_ekranı()
        {
            InitializeComponent();
        }

        private void yeni_kayit_Click(object sender, EventArgs e)
        {
            evrak_ekle form3 = new evrak_ekle();
            form3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302";
            var con1 = new SqlConnection(connectstring);
           
            DialogResult sonuc = MessageBox.Show("ARŞİV ODASINA HOŞ GELDİNİZ YAPMAK İSTEDİĞİNİZ " +
                "HER İŞLEM VERİ TABANINDA DEĞİŞİKLİK YAPACAKTIR, " +
                "BUNDAN KAYNAKLI OLARAK LÜTFEN DİKKATLİ İŞLEM YAPINIZ.",
                "DİKKAT !!!!",MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
            {

            }
            else if (sonuc == DialogResult.Cancel)
            {
                this.Close();
                Application.Exit();
            }


        }

        private void neyapmakistiyorsunuz_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            güncellemekrani guncelleme = new güncellemekrani();
            guncelleme.Show();
            this.Hide();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            giris_ekrani form1 = new giris_ekrani();
            form1.Show();
            this.Close();
        }

        private void kayit_ara_Click(object sender, EventArgs e)
        {
            Kayıt_Ara kayitara = new Kayıt_Ara();
            kayitara.Show();
            this.Hide();
        }
    }
}
