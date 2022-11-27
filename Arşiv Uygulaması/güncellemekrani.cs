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
    public partial class güncellemekrani : Form
    {
        public güncellemekrani()
        {
            InitializeComponent();
        }

        private void güncellemekrani_Load(object sender, EventArgs e)
        {
            
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            
            SqlCommand komut = new SqlCommand("select Id from Evrak", con1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr;
            con1.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                klasor_ıd_combobox.Items.Add(dr["Id"]);
            }

            string connectstring2 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con2 = new SqlConnection(connectstring2);

            SqlCommand komut2 = new SqlCommand("select Evrak_Adı from Evrak", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            SqlDataReader dr2;
            con2.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_evrak_adi.Items.Add(dr2["Evrak_Adı"]);
            }
            string connectstring3 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con3 = new SqlConnection(connectstring3);

            SqlCommand komut3 = new SqlCommand("select Dosya_Adı from Dosya", con3);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            SqlDataReader dr3;
            con3.Open();
            dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_dosya_adi.Items.Add(dr3["Dosya_Adı"]);
            }
            string connectstring4 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con4 = new SqlConnection(connectstring4);

            SqlCommand komut4 = new SqlCommand("select Id from Dosya", con4);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            SqlDataReader dr4;
            con4.Open();
            dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox_dosya_ıd.Items.Add(dr4["Id"]);
            }
            string connectstring5 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con5 = new SqlConnection(connectstring5);

            SqlCommand komut5 = new SqlCommand("select Klasör_Adı from [Klasör.]", con5);
            SqlDataAdapter da5 = new SqlDataAdapter(komut5);
            SqlDataReader dr5;
            con5.Open();
            dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox_klasor_adi.Items.Add(dr5["Klasör_Adı"]);
            }
            string connectstring6 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con6 = new SqlConnection(connectstring6);

            SqlCommand komut6 = new SqlCommand("select Id from [Klasör.]", con6);
            SqlDataAdapter da6 = new SqlDataAdapter(komut6);
            SqlDataReader dr6;
            con6.Open();
            dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                comboBox_klasor_id.Items.Add(dr6["Id"]);
            }
            string connectstring7 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con7 = new SqlConnection(connectstring7);

            SqlCommand komut7 = new SqlCommand("select Raf_Adı from Raf", con7);
            SqlDataAdapter da7 = new SqlDataAdapter(komut7);
            SqlDataReader dr7;
            con7.Open();
            dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                comboBox_raf_adi.Items.Add(dr7["Raf_Adı"]);
            }
            string connectstring8 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con8 = new SqlConnection(connectstring8);

            SqlCommand komut8 = new SqlCommand("select Id from Raf", con8);
            SqlDataAdapter da8 = new SqlDataAdapter(komut8);
            SqlDataReader dr8;
            con8.Open();
            dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                comboBox_raf_ıd.Items.Add(dr8["Id"]);
            }
            string connectstring9 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con9 = new SqlConnection(connectstring9);

            SqlCommand komut9 = new SqlCommand("select Bolum_Adi from Bölüm", con9);
            SqlDataAdapter da9 = new SqlDataAdapter(komut9);
            SqlDataReader dr9;
            con9.Open();
            dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                comboBox_bolum_adi.Items.Add(dr9["Bolum_Adi"]);
            }
            string connectstring10 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con10 = new SqlConnection(connectstring10);

            SqlCommand komut10 = new SqlCommand("select Id from Bölüm", con10);
            SqlDataAdapter da10 = new SqlDataAdapter(komut10);
            SqlDataReader dr10;
            con10.Open();
            dr10 = komut10.ExecuteReader();
            while (dr10.Read())
            {
                comboBox_bolum_ıd.Items.Add(dr10["Id"]);
            }
            string connectstring11 = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con11 = new SqlConnection(connectstring11);

            SqlCommand komut11 = new SqlCommand("select Oda_Adı from Oda", con11);
            SqlDataAdapter da11 = new SqlDataAdapter(komut11);
            SqlDataReader dr11;
            con11.Open();
            dr11 = komut11.ExecuteReader();
            while (dr11.Read())
            {
               comboBox_oda_adi.Items.Add(dr11["Oda_Adı"]);
            }
        }

        private void klasor_adi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guncelleme_butonu_Click(object sender, EventArgs e)
        {
            if (comboBox_evrak_adi.Text!="")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set Evrak_Adı=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_evrak_adi.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_dosya_adi.Text != "")
            {
                
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();             
                SqlCommand komut = new SqlCommand("update Evrak set [Dosya Adı]=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_dosya_adi.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_dosya_ıd.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set Dosya_Id=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_dosya_ıd.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_klasor_adi.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set [Klasör Adı]=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_klasor_adi.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_klasor_id.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set Klasor_Id=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_klasor_id.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_raf_adi.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set [Raf Adı]=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_raf_adi.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }           
            if (comboBox_raf_ıd.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set Raf_Id=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_raf_ıd.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_bolum_adi.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set [Bölüm Adı]=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_bolum_adi.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_bolum_ıd.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set Bolum_Id=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_bolum_ıd.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }
            if (comboBox_oda_adi.Text != "")
            {
                string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
                var con1 = new SqlConnection(connectstring);
                con1.Open();
                SqlCommand komut = new SqlCommand("update Evrak set [Oda Adı]=@p1 where Id=@id", con1);
                komut.Parameters.AddWithValue("@p1", comboBox_oda_adi.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@id", klasor_ıd_combobox.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                con1.Close();
            }

            MessageBox.Show("Güncellendi","Bilgi");


        }

        private void CİKİS_BUTONU_Click(object sender, EventArgs e)
        {
            giris_ekrani form1 = new giris_ekrani();
            form1.Show();
            this.Close();
        }

        private void GERİ_BUTONU_Click(object sender, EventArgs e)
        {
            islem_ekranı form2 = new islem_ekranı();
            form2.Show();
            this.Close();
        }

        private void sil_butonu_Click(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            con1.Open();
            SqlCommand komut = new SqlCommand("Delete from Evrak where Id=@id", con1);
            komut.Parameters.AddWithValue("@id",klasor_ıd_combobox.SelectedItem.ToString());
            komut.ExecuteNonQuery();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Evrak Where Id = '" + (klasor_ıd_combobox.Text) + "'", con1);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302;Password=webmobile.302";
            var con1 = new SqlConnection(connectstring);
            SqlDataAdapter da = new SqlDataAdapter("select * from Evrak ", con1);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
