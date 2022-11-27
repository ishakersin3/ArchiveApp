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
    public partial class Tek_Tek_Ekleme : Form
    {
        public Tek_Tek_Ekleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (oda_adı.Text!="")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                string kayit = "insert into Oda(Oda_Adı) Values (@odaadi)";
                SqlCommand komut = new SqlCommand(kayit, con1);
                komut.Parameters.AddWithValue("@odaadi", oda_adı.Text);
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (bolum_adı.Text != "" && oda_id_combobox.Text !="")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                string kayit = "insert into Bölüm(Bolum_Adi,Oda_Id) Values (@bolumadi,@odaid)";
                SqlCommand komut = new SqlCommand(kayit, con1);
                komut.Parameters.AddWithValue("@bolumadi", bolum_adı.Text);
                komut.Parameters.AddWithValue("@odaid", oda_id_combobox.Text);
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (raf_adı.Text != "" && bolum_id_combobox.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                string kayit = "insert into Raf(Raf_Adı,Bolum_Id) Values (@rafadi,@bolumıd)";
                SqlCommand komut = new SqlCommand(kayit, con1);
                komut.Parameters.AddWithValue("@rafadi", raf_adı.Text);
                komut.Parameters.AddWithValue("@bolumıd", bolum_id_combobox.Text);
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (klasor_adi.Text != "" && raf_ıd_combobox.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                string kayit = "insert into [Klasör.](Klasör_Adı,Raf_Id) Values (@klasoradi,@rafid)";
                SqlCommand komut = new SqlCommand(kayit, con1);
                komut.Parameters.AddWithValue("@klasoradi", klasor_adi.Text);
                komut.Parameters.AddWithValue("@rafid", raf_ıd_combobox.Text);
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (dosya_adı.Text != "" && klasor_ıd_combobox.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                string kayit = "insert into Dosya(Dosya_Adı,Klasor_Id) Values (@dosyaadi,@klasorid)";
                SqlCommand komut = new SqlCommand(kayit, con1);
                komut.Parameters.AddWithValue("@dosyaadi", dosya_adı.Text);
                komut.Parameters.AddWithValue("@klasorid", klasor_ıd_combobox.Text);
                komut.ExecuteNonQuery();
                con1.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris_ekrani form1 = new giris_ekrani();
            form1.Show();
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            evrak_ekle ekle = new evrak_ekle();
            ekle.Show();
            this.Hide();
        }

        private void Tek_Tek_Ekleme_Load(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);

            SqlCommand komut = new SqlCommand("select Id from Oda", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr;
            con1.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                oda_id_combobox.Items.Add(dr["Id"]);
            }
            con1.Close();

            string connectstring2 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con2 = new SqlConnection(connectstring2);
            SqlCommand komut2 = new SqlCommand("select Id from Bölüm", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            SqlDataReader dr2;
            con2.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                bolum_id_combobox.Items.Add(dr2["Id"]);
            }
            con2.Close();

            string connectstring3 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con3 = new SqlConnection(connectstring3);
            SqlCommand komut3 = new SqlCommand("select Id from Raf", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            SqlDataReader dr3;
            con3.Open();
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                raf_ıd_combobox.Items.Add(dr3["Id"]);
            }
            con3.Close();

            string connectstring4 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con4 = new SqlConnection(connectstring4);
            SqlCommand komut4 = new SqlCommand("select Id from [Klasör.]", con4);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            SqlDataReader dr4;
            con4.Open();
            dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                klasor_ıd_combobox.Items.Add(dr4["Id"]);
            }
            con3.Close();
        }
    }
}
