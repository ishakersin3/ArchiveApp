namespace Arşiv_Uygulaması
{
    partial class giris_ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_ekrani));
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.karsilama_mesaji = new System.Windows.Forms.Label();
            this.giris_butonu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikis_butonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.BackColor = System.Drawing.Color.White;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(182, 127);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(141, 26);
            this.lbl_kullaniciadi.TabIndex = 0;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.White;
            this.lbl_sifre.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre.Location = new System.Drawing.Point(182, 193);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(65, 26);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Location = new System.Drawing.Point(389, 133);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(169, 20);
            this.kullaniciadi.TabIndex = 2;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(389, 199);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(169, 20);
            this.sifre.TabIndex = 3;
            // 
            // karsilama_mesaji
            // 
            this.karsilama_mesaji.AutoSize = true;
            this.karsilama_mesaji.BackColor = System.Drawing.Color.White;
            this.karsilama_mesaji.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karsilama_mesaji.Location = new System.Drawing.Point(281, 64);
            this.karsilama_mesaji.Name = "karsilama_mesaji";
            this.karsilama_mesaji.Size = new System.Drawing.Size(233, 51);
            this.karsilama_mesaji.TabIndex = 4;
            this.karsilama_mesaji.Text = "HOŞGELDİNİZ";
            this.karsilama_mesaji.Click += new System.EventHandler(this.karsilama_mesaji_Click);
            // 
            // giris_butonu
            // 
            this.giris_butonu.BackColor = System.Drawing.Color.White;
            this.giris_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_butonu.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_butonu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giris_butonu.Location = new System.Drawing.Point(333, 267);
            this.giris_butonu.Margin = new System.Windows.Forms.Padding(45, 45, 45, 28);
            this.giris_butonu.Name = "giris_butonu";
            this.giris_butonu.Size = new System.Drawing.Size(116, 31);
            this.giris_butonu.TabIndex = 5;
            this.giris_butonu.Text = "GİRİŞ";
            this.giris_butonu.UseVisualStyleBackColor = false;
            this.giris_butonu.Click += new System.EventHandler(this.giris_butonu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cikis_butonu
            // 
            this.cikis_butonu.BackColor = System.Drawing.Color.White;
            this.cikis_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_butonu.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis_butonu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cikis_butonu.Location = new System.Drawing.Point(476, 267);
            this.cikis_butonu.Margin = new System.Windows.Forms.Padding(45, 45, 45, 28);
            this.cikis_butonu.Name = "cikis_butonu";
            this.cikis_butonu.Size = new System.Drawing.Size(116, 31);
            this.cikis_butonu.TabIndex = 7;
            this.cikis_butonu.Text = "ÇIKIŞ";
            this.cikis_butonu.UseVisualStyleBackColor = false;
            this.cikis_butonu.Click += new System.EventHandler(this.cikis_butonu_Click);
            // 
            // giris_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikis_butonu);
            this.Controls.Add(this.giris_butonu);
            this.Controls.Add(this.karsilama_mesaji);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "giris_ekrani";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label karsilama_mesaji;
        private System.Windows.Forms.Button giris_butonu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cikis_butonu;
    }
}

