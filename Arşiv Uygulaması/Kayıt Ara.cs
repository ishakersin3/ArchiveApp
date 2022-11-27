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
    public partial class Kayıt_Ara : Form
    {
        public Kayıt_Ara()
        {
            InitializeComponent();
        }

        private void odaNumarasıİleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            SqlCommand komut = new SqlCommand("select * from Evrak", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            arama_combobox.ValueMember = "Dosya_Id";
            arama_combobox.DisplayMember = "Dosya Adı";
            arama_combobox.DataSource = dt;
            con1.Close();
            arama_combobox.ResetText();


        }

        private void aRAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lutfen_numara.Text = "Lütfen Klasör Adını Giriniz:";
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            SqlCommand komut = new SqlCommand("select * from Evrak", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            arama_combobox.ValueMember = "Klasor_Id";
            arama_combobox.DisplayMember = "Klasör Adı";
            arama_combobox.DataSource = dt;
            con1.Close();
            arama_combobox.ResetText();


        }

        private void aRAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lutfen_numara.Text = "Lütfen Raf Adını Giriniz:";
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            SqlCommand komut = new SqlCommand("select * from Evrak", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            arama_combobox.ValueMember = "Raf_Id";
            arama_combobox.DisplayMember = "Raf Adı";
            arama_combobox.DataSource = dt;
            con1.Close();
            arama_combobox.ResetText();
        }

        private void aRAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lutfen_numara.Text = "Lütfen Bölüm Adını Giriniz:";
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            SqlCommand komut = new SqlCommand("select * from Evrak", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            arama_combobox.ValueMember = "Bolum_Id";
            arama_combobox.DisplayMember = "Bölüm Adı";
            arama_combobox.DataSource = dt;
            con1.Close();
            arama_combobox.ResetText();
        }

        private void aRAToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lutfen_numara.Text = "Lütfen Oda Adı Giriniz:";
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            SqlCommand komut = new SqlCommand("select * from Evrak", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            arama_combobox.ValueMember = "Oda_Id";
            arama_combobox.DisplayMember = "Oda Adı";
            arama_combobox.DataSource = dt;
            con1.Close();
            arama_combobox.ResetText();
        }

        private void ara_Click(object sender, EventArgs e)
        {

            if (lutfen_numara.Text[7]=='D')
            {
                
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                SqlDataAdapter da = new SqlDataAdapter("select * from Evrak Where [Dosya Adı] = '" + (arama_combobox.Text) + "'", con1);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else if (lutfen_numara.Text[7] == 'K')
            {
                
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                SqlDataAdapter da = new SqlDataAdapter("select * from Evrak Where [Klasör Adı] = '" + (arama_combobox.Text) + "'", con1);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else if (lutfen_numara.Text[7] == 'R')
            {
                
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                SqlDataAdapter da = new SqlDataAdapter("select * from Evrak Where [Raf Adı] = '" + (arama_combobox.Text) + "'", con1);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (lutfen_numara.Text[7] == 'B')
            {
                
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                SqlDataAdapter da = new SqlDataAdapter("select * from Evrak Where [Bölüm Adı] = '" + (arama_combobox.Text) + "'", con1);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            else if (lutfen_numara.Text[7] == 'O')
            {
               
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                SqlDataAdapter da = new SqlDataAdapter("select * from Evrak Where [Oda Adı] = '" + (arama_combobox.Text) + "'", con1);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }


        }

        private void Kayıt_Ara_Load(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            SqlCommand komut = new SqlCommand("select * from Evrak", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            arama_combobox.ValueMember = "Dosya_Id";
            arama_combobox.DisplayMember = "Dosya Adı";
            arama_combobox.DataSource = dt;
            con1.Close();
            arama_combobox.ResetText();


        }

        private void arama_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rafNumarasıİleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bölümNumarasıİleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            giris_ekrani form1 = new giris_ekrani();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris_ekrani form1 = new giris_ekrani();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islem_ekranı form2 = new islem_ekranı();
            form2.Show();
            this.Close();
        }
    }
}
