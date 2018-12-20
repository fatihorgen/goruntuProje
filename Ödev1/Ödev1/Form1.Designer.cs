namespace Ödev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnaGoruntu = new System.Windows.Forms.PictureBox();
            this.IslenmısGoruntu = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baglantiyikes = new System.Windows.Forms.Button();
            this.baglan = new System.Windows.Forms.Button();
            this.cihazlaribul = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.baud = new System.Windows.Forms.ComboBox();
            this.kirmizi = new System.Windows.Forms.TrackBar();
            this.yesil = new System.Windows.Forms.TrackBar();
            this.mavi = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goruntucihazlari = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.baslat = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.ekraniyakala = new System.Windows.Forms.Button();
            this.renkyakala = new System.Windows.Forms.RadioButton();
            this.kordinat = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aynalama = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.proje3C = new System.Windows.Forms.Button();
            this.proje2C = new System.Windows.Forms.Button();
            this.proje1C = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnaGoruntu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IslenmısGoruntu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kirmizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // AnaGoruntu
            // 
            this.AnaGoruntu.Location = new System.Drawing.Point(13, 34);
            this.AnaGoruntu.Name = "AnaGoruntu";
            this.AnaGoruntu.Size = new System.Drawing.Size(414, 322);
            this.AnaGoruntu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnaGoruntu.TabIndex = 1;
            this.AnaGoruntu.TabStop = false;
            // 
            // IslenmısGoruntu
            // 
            this.IslenmısGoruntu.Location = new System.Drawing.Point(659, 31);
            this.IslenmısGoruntu.Name = "IslenmısGoruntu";
            this.IslenmısGoruntu.Size = new System.Drawing.Size(414, 322);
            this.IslenmısGoruntu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IslenmısGoruntu.TabIndex = 2;
            this.IslenmısGoruntu.TabStop = false;
            // 
            // port
            // 
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(6, 48);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(181, 24);
            this.port.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port Seçimi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baglantiyikes);
            this.groupBox1.Controls.Add(this.baglan);
            this.groupBox1.Controls.Add(this.cihazlaribul);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.baud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Location = new System.Drawing.Point(446, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 322);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seri Port Bağlantısı";
            // 
            // baglantiyikes
            // 
            this.baglantiyikes.Location = new System.Drawing.Point(6, 278);
            this.baglantiyikes.Name = "baglantiyikes";
            this.baglantiyikes.Size = new System.Drawing.Size(181, 42);
            this.baglantiyikes.TabIndex = 10;
            this.baglantiyikes.Text = "Bağlantıyı Kes";
            this.baglantiyikes.UseVisualStyleBackColor = true;
            this.baglantiyikes.Click += new System.EventHandler(this.baglantiyikes_Click);
            // 
            // baglan
            // 
            this.baglan.Location = new System.Drawing.Point(6, 229);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(181, 42);
            this.baglan.TabIndex = 9;
            this.baglan.Text = "Bağlan";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // cihazlaribul
            // 
            this.cihazlaribul.Location = new System.Drawing.Point(6, 182);
            this.cihazlaribul.Name = "cihazlaribul";
            this.cihazlaribul.Size = new System.Drawing.Size(181, 42);
            this.cihazlaribul.TabIndex = 8;
            this.cihazlaribul.Text = "Cihazları Bul";
            this.cihazlaribul.UseVisualStyleBackColor = true;
            this.cihazlaribul.Click += new System.EventHandler(this.cihazlaribul_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 146);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // baud
            // 
            this.baud.FormattingEnabled = true;
            this.baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.baud.Location = new System.Drawing.Point(6, 106);
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(181, 24);
            this.baud.TabIndex = 5;
            // 
            // kirmizi
            // 
            this.kirmizi.Location = new System.Drawing.Point(6, 51);
            this.kirmizi.Maximum = 255;
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(347, 56);
            this.kirmizi.TabIndex = 6;
            this.kirmizi.Scroll += new System.EventHandler(this.kirmizi_Scroll);
            // 
            // yesil
            // 
            this.yesil.Location = new System.Drawing.Point(359, 51);
            this.yesil.Maximum = 255;
            this.yesil.Name = "yesil";
            this.yesil.Size = new System.Drawing.Size(347, 56);
            this.yesil.TabIndex = 7;
            this.yesil.Scroll += new System.EventHandler(this.yesil_Scroll);
            // 
            // mavi
            // 
            this.mavi.Location = new System.Drawing.Point(708, 51);
            this.mavi.Maximum = 255;
            this.mavi.Name = "mavi";
            this.mavi.Size = new System.Drawing.Size(347, 56);
            this.mavi.TabIndex = 8;
            this.mavi.Scroll += new System.EventHandler(this.mavi_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Blue";
            // 
            // goruntucihazlari
            // 
            this.goruntucihazlari.FormattingEnabled = true;
            this.goruntucihazlari.Location = new System.Drawing.Point(6, 53);
            this.goruntucihazlari.Name = "goruntucihazlari";
            this.goruntucihazlari.Size = new System.Drawing.Size(193, 24);
            this.goruntucihazlari.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Görüntü Cihazları";
            // 
            // baslat
            // 
            this.baslat.Location = new System.Drawing.Point(6, 86);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(193, 42);
            this.baslat.TabIndex = 14;
            this.baslat.Text = "Başlat";
            this.baslat.UseVisualStyleBackColor = true;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // durdur
            // 
            this.durdur.Location = new System.Drawing.Point(6, 134);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(193, 42);
            this.durdur.TabIndex = 15;
            this.durdur.Text = "Durdur";
            this.durdur.UseVisualStyleBackColor = true;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // ekraniyakala
            // 
            this.ekraniyakala.Location = new System.Drawing.Point(6, 182);
            this.ekraniyakala.Name = "ekraniyakala";
            this.ekraniyakala.Size = new System.Drawing.Size(193, 42);
            this.ekraniyakala.TabIndex = 16;
            this.ekraniyakala.Text = "Ekranı Yakala";
            this.ekraniyakala.UseVisualStyleBackColor = true;
            this.ekraniyakala.Click += new System.EventHandler(this.ekraniyakala_Click);
            // 
            // renkyakala
            // 
            this.renkyakala.AutoSize = true;
            this.renkyakala.Location = new System.Drawing.Point(6, 286);
            this.renkyakala.Name = "renkyakala";
            this.renkyakala.Size = new System.Drawing.Size(109, 21);
            this.renkyakala.TabIndex = 17;
            this.renkyakala.TabStop = true;
            this.renkyakala.Text = "Renk Yakala";
            this.renkyakala.UseVisualStyleBackColor = true;
            // 
            // kordinat
            // 
            this.kordinat.AutoSize = true;
            this.kordinat.Location = new System.Drawing.Point(10, 320);
            this.kordinat.Name = "kordinat";
            this.kordinat.Size = new System.Drawing.Size(144, 21);
            this.kordinat.TabIndex = 18;
            this.kordinat.Text = "Hedef Kordinatları";
            this.kordinat.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 384);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(190, 75);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kirmizi);
            this.groupBox2.Controls.Add(this.yesil);
            this.groupBox2.Controls.Add(this.mavi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1060, 113);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Düzeyleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aynalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Controls.Add(this.durdur);
            this.groupBox3.Controls.Add(this.goruntucihazlari);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.kordinat);
            this.groupBox3.Controls.Add(this.baslat);
            this.groupBox3.Controls.Add(this.renkyakala);
            this.groupBox3.Controls.Add(this.ekraniyakala);
            this.groupBox3.Location = new System.Drawing.Point(1089, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 559);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Görüntü Ayarları";
            // 
            // aynalama
            // 
            this.aynalama.Location = new System.Drawing.Point(6, 230);
            this.aynalama.Name = "aynalama";
            this.aynalama.Size = new System.Drawing.Size(193, 42);
            this.aynalama.TabIndex = 22;
            this.aynalama.Text = "Aynalama";
            this.aynalama.UseVisualStyleBackColor = true;
            this.aynalama.Click += new System.EventHandler(this.aynalama_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "1. ve 2. Cisim Kordinatları";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 467);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(190, 75);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.proje3C);
            this.groupBox4.Controls.Add(this.proje2C);
            this.groupBox4.Controls.Add(this.proje1C);
            this.groupBox4.Location = new System.Drawing.Point(13, 498);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1060, 95);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proje Geçişleri";
            // 
            // proje3C
            // 
            this.proje3C.Location = new System.Drawing.Point(711, 33);
            this.proje3C.Name = "proje3C";
            this.proje3C.Size = new System.Drawing.Size(346, 45);
            this.proje3C.TabIndex = 2;
            this.proje3C.Text = "Proje 3 için C# Kod Bloğunu Aktif Et";
            this.proje3C.UseVisualStyleBackColor = true;
            this.proje3C.Click += new System.EventHandler(this.proje3C_Click);
            // 
            // proje2C
            // 
            this.proje2C.Location = new System.Drawing.Point(359, 33);
            this.proje2C.Name = "proje2C";
            this.proje2C.Size = new System.Drawing.Size(346, 45);
            this.proje2C.TabIndex = 1;
            this.proje2C.Text = "Proje 2 için C# Kod Bloğunu Aktif Et";
            this.proje2C.UseVisualStyleBackColor = true;
            this.proje2C.Click += new System.EventHandler(this.proje2C_Click);
            // 
            // proje1C
            // 
            this.proje1C.Location = new System.Drawing.Point(6, 33);
            this.proje1C.Name = "proje1C";
            this.proje1C.Size = new System.Drawing.Size(346, 45);
            this.proje1C.TabIndex = 0;
            this.proje1C.Text = "Proje 1 için C# Kod Bloğunu Aktif Et";
            this.proje1C.UseVisualStyleBackColor = true;
            this.proje1C.Click += new System.EventHandler(this.proje1C_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IslenmısGoruntu);
            this.Controls.Add(this.AnaGoruntu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnaGoruntu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IslenmısGoruntu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kirmizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.PictureBox AnaGoruntu;
        private System.Windows.Forms.PictureBox IslenmısGoruntu;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.Button baglantiyikes;
        private System.Windows.Forms.Button baglan;
        private System.Windows.Forms.Button cihazlaribul;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar kirmizi;
        private System.Windows.Forms.TrackBar yesil;
        private System.Windows.Forms.TrackBar mavi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox goruntucihazlari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button ekraniyakala;
        private System.Windows.Forms.RadioButton renkyakala;
        private System.Windows.Forms.CheckBox kordinat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button proje3C;
        private System.Windows.Forms.Button proje2C;
        private System.Windows.Forms.Button proje1C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button aynalama;
    }
}

