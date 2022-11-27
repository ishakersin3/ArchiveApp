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
    public partial class yukleme_ekrani : Form
    {
        public yukleme_ekrani()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectstring = "Data Source=302-01;Initial Catalog=Arsiv_Odasi_Projesi;Persist Security Info=True;User ID=webMobile_302";
            var con1 = new SqlConnection(connectstring);          
            timer1.Start();           
        }
        int zaman = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            yuklemebari.Value = zaman;
            zaman++;
            if (zaman>100)
            {
                timer1.Stop();
                islem_ekranı form2 = new islem_ekranı();
                form2.Show();
                this.Hide();
            }
        }

        private void yuklemebari_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
