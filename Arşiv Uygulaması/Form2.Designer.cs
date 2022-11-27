namespace Arşiv_Uygulaması
{
    partial class islem_ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(islem_ekranı));
            this.yeni_kayit = new System.Windows.Forms.Button();
            this.kayit_ara = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayit_duzenle = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yeni_kayit
            // 
            this.yeni_kayit.BackColor = System.Drawing.Color.Transparent;
            this.yeni_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeni_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeni_kayit.Location = new System.Drawing.Point(32, 71);
            this.yeni_kayit.Name = "yeni_kayit";
            this.yeni_kayit.Size = new System.Drawing.Size(165, 63);
            this.yeni_kayit.TabIndex = 0;
            this.yeni_kayit.Text = "KAYIT EKLE";
            this.yeni_kayit.UseVisualStyleBackColor = false;
            this.yeni_kayit.Click += new System.EventHandler(this.yeni_kayit_Click);
            // 
            // kayit_ara
            // 
            this.kayit_ara.BackColor = System.Drawing.Color.Transparent;
            this.kayit_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_ara.Location = new System.Drawing.Point(32, 170);
            this.kayit_ara.Name = "kayit_ara";
            this.kayit_ara.Size = new System.Drawing.Size(165, 63);
            this.kayit_ara.TabIndex = 2;
            this.kayit_ara.Text = "KAYIT ARA";
            this.kayit_ara.UseVisualStyleBackColor = false;
            this.kayit_ara.Click += new System.EventHandler(this.kayit_ara_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // kayit_duzenle
            // 
            this.kayit_duzenle.BackColor = System.Drawing.Color.Transparent;
            this.kayit_duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_duzenle.Location = new System.Drawing.Point(32, 269);
            this.kayit_duzenle.Name = "kayit_duzenle";
            this.kayit_duzenle.Size = new System.Drawing.Size(165, 63);
            this.kayit_duzenle.TabIndex = 7;
            this.kayit_duzenle.Text = "KAYIT DÜZENLE";
            this.kayit_duzenle.UseVisualStyleBackColor = false;
            this.kayit_duzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikis.Location = new System.Drawing.Point(32, 366);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(165, 63);
            this.cikis.TabIndex = 8;
            this.cikis.Text = "ÇIKIŞ YAP";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // islem_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.kayit_duzenle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kayit_ara);
            this.Controls.Add(this.yeni_kayit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "islem_ekranı";
            this.Text = "İşlem Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yeni_kayit;
        private System.Windows.Forms.Button kayit_ara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kayit_duzenle;
        private System.Windows.Forms.Button cikis;
    }
}