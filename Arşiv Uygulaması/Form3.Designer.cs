namespace Arşiv_Uygulaması
{
    partial class evrak_ekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.evrak_adi = new System.Windows.Forms.Label();
            this.dosyaıd = new System.Windows.Forms.Label();
            this.klasor_ıd = new System.Windows.Forms.Label();
            this.raf_ıd = new System.Windows.Forms.Label();
            this.bolum_ıd = new System.Windows.Forms.Label();
            this.oda_ıd = new System.Windows.Forms.Label();
            this.yenievrakadi = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniodaadi = new System.Windows.Forms.TextBox();
            this.yeniodanumarasi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yenibolumnumarasi = new System.Windows.Forms.ComboBox();
            this.yenibolmadi = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yenidosyaadi = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yenirafadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yeniklasöradi = new System.Windows.Forms.TextBox();
            this.sql_kaydet = new System.Windows.Forms.Button();
            this.geri_gel = new System.Windows.Forms.Button();
            this.oda_ekle = new System.Windows.Forms.Button();
            this.raf_ekle = new System.Windows.Forms.Button();
            this.bolum_ekle = new System.Windows.Forms.Button();
            this.dosya_ekle = new System.Windows.Forms.Button();
            this.klasor_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evrak_adi
            // 
            this.evrak_adi.AutoSize = true;
            this.evrak_adi.BackColor = System.Drawing.Color.Transparent;
            this.evrak_adi.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evrak_adi.Location = new System.Drawing.Point(36, 18);
            this.evrak_adi.Name = "evrak_adi";
            this.evrak_adi.Size = new System.Drawing.Size(101, 23);
            this.evrak_adi.TabIndex = 0;
            this.evrak_adi.Text = "Evrak Adı:";
            this.evrak_adi.Click += new System.EventHandler(this.evrak_adi_Click);
            // 
            // dosyaıd
            // 
            this.dosyaıd.AutoSize = true;
            this.dosyaıd.BackColor = System.Drawing.Color.Transparent;
            this.dosyaıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosyaıd.Location = new System.Drawing.Point(301, 186);
            this.dosyaıd.Name = "dosyaıd";
            this.dosyaıd.Size = new System.Drawing.Size(147, 23);
            this.dosyaıd.TabIndex = 1;
            this.dosyaıd.Text = "Dosya Numarası";
            // 
            // klasor_ıd
            // 
            this.klasor_ıd.AutoSize = true;
            this.klasor_ıd.BackColor = System.Drawing.Color.Transparent;
            this.klasor_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klasor_ıd.Location = new System.Drawing.Point(301, 309);
            this.klasor_ıd.Name = "klasor_ıd";
            this.klasor_ıd.Size = new System.Drawing.Size(149, 23);
            this.klasor_ıd.TabIndex = 2;
            this.klasor_ıd.Text = "Klasör Numarası";
            // 
            // raf_ıd
            // 
            this.raf_ıd.AutoSize = true;
            this.raf_ıd.BackColor = System.Drawing.Color.Transparent;
            this.raf_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raf_ıd.Location = new System.Drawing.Point(301, 249);
            this.raf_ıd.Name = "raf_ıd";
            this.raf_ıd.Size = new System.Drawing.Size(123, 23);
            this.raf_ıd.TabIndex = 3;
            this.raf_ıd.Text = "Raf Numarası";
            // 
            // bolum_ıd
            // 
            this.bolum_ıd.AutoSize = true;
            this.bolum_ıd.BackColor = System.Drawing.Color.Transparent;
            this.bolum_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolum_ıd.Location = new System.Drawing.Point(301, 124);
            this.bolum_ıd.Name = "bolum_ıd";
            this.bolum_ıd.Size = new System.Drawing.Size(151, 23);
            this.bolum_ıd.TabIndex = 4;
            this.bolum_ıd.Text = "Bölüm Numarası";
            // 
            // oda_ıd
            // 
            this.oda_ıd.AutoSize = true;
            this.oda_ıd.BackColor = System.Drawing.Color.Transparent;
            this.oda_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oda_ıd.Location = new System.Drawing.Point(301, 63);
            this.oda_ıd.Name = "oda_ıd";
            this.oda_ıd.Size = new System.Drawing.Size(128, 23);
            this.oda_ıd.TabIndex = 5;
            this.oda_ıd.Text = "Oda Numarası";
            this.oda_ıd.Click += new System.EventHandler(this.oda_ıd_Click);
            // 
            // yenievrakadi
            // 
            this.yenievrakadi.Location = new System.Drawing.Point(153, 21);
            this.yenievrakadi.Name = "yenievrakadi";
            this.yenievrakadi.Size = new System.Drawing.Size(396, 20);
            this.yenievrakadi.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.comboBox2.Location = new System.Drawing.Point(305, 335);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Oda Adı";
            // 
            // yeniodaadi
            // 
            this.yeniodaadi.Location = new System.Drawing.Point(40, 89);
            this.yeniodaadi.Name = "yeniodaadi";
            this.yeniodaadi.Size = new System.Drawing.Size(211, 20);
            this.yeniodaadi.TabIndex = 10;
            // 
            // yeniodanumarasi
            // 
            this.yeniodanumarasi.FormattingEnabled = true;
            this.yeniodanumarasi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 ",
            "6",
            "7",
            "8"});
            this.yeniodanumarasi.Location = new System.Drawing.Point(305, 89);
            this.yeniodanumarasi.Name = "yeniodanumarasi";
            this.yeniodanumarasi.Size = new System.Drawing.Size(145, 21);
            this.yeniodanumarasi.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bölüm Adı";
            // 
            // yenibolumnumarasi
            // 
            this.yenibolumnumarasi.FormattingEnabled = true;
            this.yenibolumnumarasi.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14"});
            this.yenibolumnumarasi.Location = new System.Drawing.Point(307, 153);
            this.yenibolumnumarasi.Name = "yenibolumnumarasi";
            this.yenibolumnumarasi.Size = new System.Drawing.Size(145, 21);
            this.yenibolumnumarasi.TabIndex = 13;
            // 
            // yenibolmadi
            // 
            this.yenibolmadi.Location = new System.Drawing.Point(40, 153);
            this.yenibolmadi.Name = "yenibolmadi";
            this.yenibolmadi.Size = new System.Drawing.Size(211, 20);
            this.yenibolmadi.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(305, 215);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(145, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dosya Adı";
            // 
            // yenidosyaadi
            // 
            this.yenidosyaadi.Location = new System.Drawing.Point(44, 215);
            this.yenidosyaadi.Name = "yenidosyaadi";
            this.yenidosyaadi.Size = new System.Drawing.Size(211, 20);
            this.yenidosyaadi.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox4.Location = new System.Drawing.Point(305, 274);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(151, 21);
            this.comboBox4.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Raf Adı";
            // 
            // yenirafadi
            // 
            this.yenirafadi.Location = new System.Drawing.Point(45, 275);
            this.yenirafadi.Name = "yenirafadi";
            this.yenirafadi.Size = new System.Drawing.Size(211, 20);
            this.yenirafadi.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Klasör Adı";
            // 
            // yeniklasöradi
            // 
            this.yeniklasöradi.Location = new System.Drawing.Point(45, 335);
            this.yeniklasöradi.Name = "yeniklasöradi";
            this.yeniklasöradi.Size = new System.Drawing.Size(211, 20);
            this.yeniklasöradi.TabIndex = 22;
            // 
            // sql_kaydet
            // 
            this.sql_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.sql_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sql_kaydet.Location = new System.Drawing.Point(44, 384);
            this.sql_kaydet.Name = "sql_kaydet";
            this.sql_kaydet.Size = new System.Drawing.Size(158, 33);
            this.sql_kaydet.TabIndex = 23;
            this.sql_kaydet.Text = "KAYDET";
            this.sql_kaydet.UseVisualStyleBackColor = false;
            this.sql_kaydet.Click += new System.EventHandler(this.sql_kaydet_Click);
            // 
            // geri_gel
            // 
            this.geri_gel.BackColor = System.Drawing.Color.Transparent;
            this.geri_gel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_gel.Location = new System.Drawing.Point(305, 384);
            this.geri_gel.Name = "geri_gel";
            this.geri_gel.Size = new System.Drawing.Size(158, 33);
            this.geri_gel.TabIndex = 24;
            this.geri_gel.Text = "GERİ";
            this.geri_gel.UseVisualStyleBackColor = false;
            this.geri_gel.Click += new System.EventHandler(this.geri_gel_Click);
            // 
            // oda_ekle
            // 
            this.oda_ekle.Location = new System.Drawing.Point(614, 63);
            this.oda_ekle.Name = "oda_ekle";
            this.oda_ekle.Size = new System.Drawing.Size(120, 38);
            this.oda_ekle.TabIndex = 25;
            this.oda_ekle.Text = "Sadece Oda Ekle";
            this.oda_ekle.UseVisualStyleBackColor = true;
            this.oda_ekle.Click += new System.EventHandler(this.oda_ekle_Click);
            // 
            // raf_ekle
            // 
            this.raf_ekle.Location = new System.Drawing.Point(614, 215);
            this.raf_ekle.Name = "raf_ekle";
            this.raf_ekle.Size = new System.Drawing.Size(120, 38);
            this.raf_ekle.TabIndex = 26;
            this.raf_ekle.Text = "Sadece Raf Ekle";
            this.raf_ekle.UseVisualStyleBackColor = true;
            this.raf_ekle.Click += new System.EventHandler(this.raf_ekle_Click);
            // 
            // bolum_ekle
            // 
            this.bolum_ekle.Location = new System.Drawing.Point(614, 136);
            this.bolum_ekle.Name = "bolum_ekle";
            this.bolum_ekle.Size = new System.Drawing.Size(120, 38);
            this.bolum_ekle.TabIndex = 27;
            this.bolum_ekle.Text = "Sadece Bölüm Ekle";
            this.bolum_ekle.UseVisualStyleBackColor = true;
            this.bolum_ekle.Click += new System.EventHandler(this.bolum_ekle_Click);
            // 
            // dosya_ekle
            // 
            this.dosya_ekle.Location = new System.Drawing.Point(614, 294);
            this.dosya_ekle.Name = "dosya_ekle";
            this.dosya_ekle.Size = new System.Drawing.Size(120, 38);
            this.dosya_ekle.TabIndex = 28;
            this.dosya_ekle.Text = "Sadece Dosya Ekle";
            this.dosya_ekle.UseVisualStyleBackColor = true;
            this.dosya_ekle.Click += new System.EventHandler(this.dosya_ekle_Click);
            // 
            // klasor_ekle
            // 
            this.klasor_ekle.Location = new System.Drawing.Point(614, 368);
            this.klasor_ekle.Name = "klasor_ekle";
            this.klasor_ekle.Size = new System.Drawing.Size(120, 38);
            this.klasor_ekle.TabIndex = 29;
            this.klasor_ekle.Text = "Sadece Klasör Ekle";
            this.klasor_ekle.UseVisualStyleBackColor = true;
            this.klasor_ekle.Click += new System.EventHandler(this.klasor_ekle_Click);
            // 
            // evrak_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.klasor_ekle);
            this.Controls.Add(this.dosya_ekle);
            this.Controls.Add(this.bolum_ekle);
            this.Controls.Add(this.raf_ekle);
            this.Controls.Add(this.oda_ekle);
            this.Controls.Add(this.geri_gel);
            this.Controls.Add(this.sql_kaydet);
            this.Controls.Add(this.yeniklasöradi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yenirafadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.yenidosyaadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.yenibolmadi);
            this.Controls.Add(this.yenibolumnumarasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yeniodanumarasi);
            this.Controls.Add(this.yeniodaadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.yenievrakadi);
            this.Controls.Add(this.oda_ıd);
            this.Controls.Add(this.bolum_ıd);
            this.Controls.Add(this.raf_ıd);
            this.Controls.Add(this.klasor_ıd);
            this.Controls.Add(this.dosyaıd);
            this.Controls.Add(this.evrak_adi);
            this.Name = "evrak_ekle";
            this.Text = "Evrak Ekle";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label evrak_adi;
        private System.Windows.Forms.Label dosyaıd;
        private System.Windows.Forms.Label klasor_ıd;
        private System.Windows.Forms.Label raf_ıd;
        private System.Windows.Forms.Label bolum_ıd;
        private System.Windows.Forms.Label oda_ıd;
        private System.Windows.Forms.TextBox yenievrakadi;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yeniodaadi;
        private System.Windows.Forms.ComboBox yeniodanumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yenibolumnumarasi;
        private System.Windows.Forms.TextBox yenibolmadi;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yenidosyaadi;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yenirafadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yeniklasöradi;
        private System.Windows.Forms.Button sql_kaydet;
        private System.Windows.Forms.Button geri_gel;
        private System.Windows.Forms.Button oda_ekle;
        private System.Windows.Forms.Button raf_ekle;
        private System.Windows.Forms.Button bolum_ekle;
        private System.Windows.Forms.Button dosya_ekle;
        private System.Windows.Forms.Button klasor_ekle;
    }
}