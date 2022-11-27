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
    public partial class evrak_ekle : Form
    {
        public evrak_ekle()
        {
            InitializeComponent();
        }

        private void evrak_adi_Click(object sender, EventArgs e)
        {

        }

        private void oda_ıd_Click(object sender, EventArgs e)
        {

        }

        private void geri_gel_Click(object sender, EventArgs e)
        {
            islem_ekranı form2 = new islem_ekranı();
            form2.Show();
            this.Close();
        }

        private void sql_kaydet_Click(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            string kayit = "insert into Evrak(Evrak_Adı,Dosya_Id,Klasor_Id,Raf_Id,Bolum_Id,Oda_Id,[Dosya Adı],[Klasör Adı],[Raf Adı],[Bölüm Adı],[Oda Adı]) " +
                "values (@evrakadi,@dosyaıd,@klasorıd,@rafıd,@bolumıd,@odaıd,@dosyaadi,@klasoradi,@rafadi,@bolumadi,@odaadi)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, con1);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@evrakadi", yenievrakadi.Text);
            komut.Parameters.AddWithValue("@dosyaıd", comboBox3.Text);
            komut.Parameters.AddWithValue("@klasorıd", comboBox2.Text);
            komut.Parameters.AddWithValue("@rafıd", comboBox4.Text);
            komut.Parameters.AddWithValue("@bolumıd", yenibolumnumarasi.Text);
            komut.Parameters.AddWithValue("@odaıd", yeniodanumarasi.Text);
            komut.Parameters.AddWithValue("@odaadi", yeniodaadi.Text);
            komut.Parameters.AddWithValue("@bolumadi", yenibolmadi.Text);
            komut.Parameters.AddWithValue("@dosyaadi", yenidosyaadi.Text);
            komut.Parameters.AddWithValue("@rafadi", yenirafadi.Text);
            komut.Parameters.AddWithValue("@klasoradi", yeniklasöradi.Text);

            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            con1.Close();
            DialogResult sonuc= MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.","Kaydedildi",MessageBoxButtons.OKCancel);


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        private void oda_ekle_Click(object sender, EventArgs e)
        {
            Tek_Tek_Ekleme tektek = new Tek_Tek_Ekleme();
            tektek.Show();
            this.Hide();
        }

        private void bolum_ekle_Click(object sender, EventArgs e)
        {
            Tek_Tek_Ekleme tektek = new Tek_Tek_Ekleme();
            tektek.Show();
            this.Hide();
        }

        private void raf_ekle_Click(object sender, EventArgs e)
        {
            Tek_Tek_Ekleme tektek = new Tek_Tek_Ekleme();
            tektek.Show();
            this.Hide();
        }

        private void dosya_ekle_Click(object sender, EventArgs e)
        {
            Tek_Tek_Ekleme tektek = new Tek_Tek_Ekleme();
            tektek.Show();
            this.Hide();
        }

        private void klasor_ekle_Click(object sender, EventArgs e)
        {
            Tek_Tek_Ekleme tektek = new Tek_Tek_Ekleme();
            tektek.Show();
            this.Hide();
        }
    }
}
