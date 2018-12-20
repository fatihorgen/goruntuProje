using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;   
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using System.IO.Ports;   //seri port kütüphanesi
using System.Diagnostics;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        int R = 0; //renk hedefleme için kullanılan değişkenler
        int G = 0;
        int B = 0;
        private FilterInfoCollection goruntuAygitlari; //kamera aygıtlarını tespit etme değişkeni
        private VideoCaptureDevice kamera; 
        int projedurumu;
        int objeX, objeY;
        string yon,gecici;
        int obje1x, obje1y, obje2x, obje2y;
        bool yakalama = false;  
        int led;
        int aynala;
        public Form1()
        {
            InitializeComponent();
            durdur.Enabled = false;
            ekraniyakala.Enabled = false;
            goruntuAygitlari = new FilterInfoCollection(FilterCategory.VideoInputDevice); //bilgisayara bağlı olan görüntü aygıtlarını bulma ve değişkene aktarma
            if (goruntuAygitlari.Count != 0)
            {
                for(int i = 1; i <= goruntuAygitlari.Count; i++) //görüntü aygıtlarını listeliyoruz.
                {
                    string goruntuisimleri = i + ":" + goruntuAygitlari[i - 1].Name;
                    goruntucihazlari.Items.Add(goruntuisimleri);
                }
                if (goruntuAygitlari.Count == 1) //sadece 1 adet görüntü aygıtı bulunduysa seçili olarak işaretleme.
                {
                    goruntucihazlari.SelectedIndex = 0;
                    goruntucihazlari.Enabled = false;
                }
            }
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            if (goruntucihazlari.Text != "")
            {
                kamera = new VideoCaptureDevice(goruntuAygitlari[goruntucihazlari.SelectedIndex].MonikerString); //seçilmiş kamera aygıtını kayıt için ayarlama
                kamera.NewFrame += new NewFrameEventHandler(kamerayenigoruntu);  // kameradan frame kaydedip kamerayenigörüntü adlı fonk. islenmesi.
                kamera.Start();
                baslat.Enabled = false;
                durdur.Enabled = true;
                ekraniyakala.Enabled = true;
                aynalama.Enabled = true;
            }
            else
            {
                MessageBox.Show("Herhangi Bir Aygıt Seçilmemiş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        void kamerayenigoruntu(object sender,NewFrameEventArgs main)
        {
            Bitmap kaynakgoruntu = (Bitmap)main.Frame.Clone();
            Bitmap islenmisgoruntu = (Bitmap)main.Frame.Clone();
            if (aynala == 1)
            {
                Mirror Filter = new Mirror(false,true);
                Filter.ApplyInPlace(kaynakgoruntu);
                Filter.ApplyInPlace(islenmisgoruntu);
            }
            AnaGoruntu.Image = kaynakgoruntu;
            if (renkyakala.Checked)
            {
                EuclideanColorFiltering filtre = new EuclideanColorFiltering();
                filtre.CenterColor = new RGB(Color.FromArgb(R, G,B));
                filtre.Radius = 100;
                filtre.ApplyInPlace(islenmisgoruntu);  
                BlobCounter bc = new BlobCounter();  //nokta sayıcı
                bc.FilterBlobs = true;
                bc.MinHeight = 20;
                bc.MinWidth = 20;
                bc.ObjectsOrder = ObjectsOrder.Size;
                bc.ProcessImage(islenmisgoruntu);  
                Rectangle[] karesekil = bc.GetObjectsRectangles();
                if (projedurumu == 1)
                {
                    if (karesekil.Length > 0)
                    {
                        Rectangle obje = karesekil[0];
                        Graphics grafik = Graphics.FromImage(islenmisgoruntu);
                        using (Pen kenarlik = new Pen(Color.LightBlue, 3))
                        {
                            grafik.DrawRectangle(kenarlik, obje);
                        }
                        grafik.Dispose();
                        objeX = obje.X + (obje.Width / 2); //belirlediğimiz karenin x eksenindeki ortası
                        objeY = obje.Y + (obje.Height / 2); //belirlediğimiz karenin y eksenindeki ortası
                        if(kordinat.Checked)
                        {
                            this.Invoke((MethodInvoker)delegate
                                {
                                richTextBox1.Text = "x:" + objeX.ToString() + "-- Y:" + objeY.ToString() + "\n" + richTextBox1.Text + "\n";//manuel olarak yapılan kordinat
                            });
                            if(objeX > 0 && objeX <= 213 && objeY > 0 && objeY <= 160)
                            {
                                led = 2;
                            }
                            if (objeX > 213 && objeX <= 426 && objeY > 0 && objeY <= 160)
                            {
                                led = 3;
                            }
                            if (objeX > 426 && objeX <=640 && objeY > 0 && objeY <= 160)
                            {
                                led = 4;
                            }
                            if (objeX > 0 && objeX <= 213 && objeY > 160 && objeY <= 320)
                            {
                                led = 5;
                            }
                            if (objeX > 213 && objeX <= 426 && objeY > 160 && objeY <= 320)
                            {
                                led = 6;
                            }
                            if (objeX > 426 && objeX <= 640 && objeY > 160 && objeY <= 320)
                            {
                                led = 7;
                            }
                            if (objeX > 0 && objeX <= 213 && objeY > 320 && objeY <= 480)
                            {
                                led = 8;
                            }
                            if (objeX > 213 && objeX <= 426 && objeY > 320 && objeY <= 480)
                            {
                                led = 9;
                            }
                            if (objeX > 426 && objeX <= 640 && objeY > 320 && objeY <= 480)
                            {
                                led = 10;
                            }
                            if (serialPort1.IsOpen)
                            {
                                serialPort1.DataReceived += new SerialDataReceivedEventHandler(veribilgisi);
                            }
                        }
                    }
                }else if (projedurumu == 2)
                {
                    Graphics ekranortasi = Graphics.FromImage(islenmisgoruntu);
                    Pen ekrankılavuzu = new Pen(Color.LightBlue, 3);
                    ekranortasi.DrawLine(ekrankılavuzu, 240, 0, 240, 480);
                    ekranortasi.DrawLine(ekrankılavuzu, 400, 0, 400, 480);
                    if (karesekil.Length > 0)
                    {
                        Rectangle obje = karesekil[0];
                        Graphics grafik = Graphics.FromImage(islenmisgoruntu);
                        using(Pen kenarlık=new Pen(Color.White, 1))
                        {
                            grafik.DrawRectangle(kenarlık, obje);
                        }
                        grafik.Dispose();
                        objeX = obje.X + (obje.Width / 2); //belirlediğimiz karenin x eksenindeki ortası
                        objeY = obje.Y + (obje.Height / 2); //belirlediğimiz karenin y eksenindeki ortası

                        if (kordinat.Checked)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                richTextBox1.Text = "x:" + objeX.ToString() + "-- Y:" + objeY.ToString() + "\n" + richTextBox1.Text + "\n";//manuel olarak yapılan kordinat  
                            });
                            if(objeX>240 && objeX < 400)
                            {
                                yon = "dur";
                            }else if (objeX >= 400)
                            {
                                yon = "sag";
                            }else if (objeX <= 240)
                            {
                                yon = "sol";
                            }
                            if(gecici != yon)
                            {
                                gecici = yon;
                                if (serialPort1.IsOpen)
                                {
                                    serialPort1.Write(yon);
                                }
                            }
                        }
                    }
                    else
                    {
                        yon = "dur";
                        if (gecici != yon)
                        {
                            gecici = yon;
                            if (serialPort1.IsOpen)
                            {
                                serialPort1.Write(yon);
                            }
                        }
                    }
                }else if(projedurumu == 3)
                {
                    Graphics grafikmerkezi = Graphics.FromImage(islenmisgoruntu);
                    Pen kılavuzcizgileri = new Pen(Color.Yellow, 5);
                    grafikmerkezi.DrawLine(kılavuzcizgileri, 320, 0, 320, 480);
                    if(karesekil.Length>1)
                    {
                        for(int i=0;i<2;i++) //sadece iki adet rengi işaretlesin.
                        {
                            Rectangle obje = karesekil[i];
                            Graphics grafik = Graphics.FromImage(islenmisgoruntu);
                            using(Pen kenarlık=new Pen(Color.White, 1))
                            {
                                grafik.DrawRectangle(kenarlık, obje);
                                grafik.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.White, obje);
                            }
                            grafik.Dispose();

                            if (karesekil.Length >= 1)
                            {
                                Rectangle obje1 = karesekil[0];
                                Rectangle obje2 = karesekil[1];

                                obje1x = obje1.X + (obje1.Width / 2);
                                obje1y = obje1.Y + (obje1.Height / 2);

                                obje2x = obje2.X + (obje2.Width / 2);
                                obje2y = obje2.Y + (obje2.Height / 2);

                            }
                            if (kordinat.Checked)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    richTextBox1.Text = "x:" + obje1x.ToString() + "-- Y:" + obje1y.ToString() + "\n" + richTextBox1.Text + "\n";
                                    richTextBox2.Text = "x:" + obje2x.ToString() + "-- Y:" + obje2y.ToString() + "\n" + richTextBox2.Text + "\n";
                                });
                                if (serialPort1.IsOpen)
                                {
                                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(veribilgisi);
                                }
                            }
                        }
                    }
                }
            }
            if(yakalama==false)
            {
                IslenmısGoruntu.Image = islenmisgoruntu;
            }
        }
        private void veribilgisi(object sender ,SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SerialPort gelenbilgi = (SerialPort)sender;
                if (projedurumu == 1)
                {
                    if(gelenbilgi.ReadExisting()== "proje1")
                    {
                        serialPort1.Write(led.ToString());
                        //Console.Write(led+"\n");
                    }
                }else if (projedurumu == 3)
                {
                    if (gelenbilgi.ReadExisting() == "proje2a")
                    {
                        serialPort1.Write(obje1y.ToString() + "*" + obje2y.ToString());
                    }
                }
            }
        }
        private void kirmizi_Scroll(object sender, EventArgs e)
        {
            R = kirmizi.Value;
        }
        private void yesil_Scroll(object sender, EventArgs e)
        {
            G = yesil.Value;
        }
        private void mavi_Scroll(object sender, EventArgs e)
        {
            B = mavi.Value;
        }
        private void ekraniyakala_Click(object sender, EventArgs e)
        {
            if (yakalama == true)
            {
                yakalama = false;
            }
            else if (yakalama == false)
            {
                yakalama = true;
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            if (kamera.IsRunning)
            {
                kamera.Stop();
            }
            baslat.Enabled = true;
        }

        private void cihazlaribul_Click(object sender, EventArgs e)
        {
            string[] portlar = SerialPort.GetPortNames();
            port.Items.Clear();
            port.Items.AddRange(portlar);
            baglantiyikes.Enabled = false;
        }

        private void baglan_Click(object sender, EventArgs e)
        {
            if(port.Text != "" && baud.Text != "")
            {
                serialPort1.PortName = port.Text;
                serialPort1.BaudRate = Convert.ToInt32(baud.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();
                progressBar1.Value = 100;
                baglan.Enabled = false;
                baglantiyikes.Enabled = true;
                serialPort1.Write("Veri");

            }else
            {
                MessageBox.Show("Eksik Ayar","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void baglantiyikes_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                baglan.Enabled = true;
                baglantiyikes.Enabled = false;
            }
        }

        private void proje1A_Click(object sender, EventArgs e)
        {

        }

        private void aynalama_Click(object sender, EventArgs e)
        {
            if (aynala == 0)
            {
                aynala = 1;
                aynalama.BackColor = Color.FromArgb(255, 65, 40);
                aynalama.ForeColor = Color.FromArgb(255,255,255);
            }else if (aynala == 1)
            {
                aynala = 0;
                aynalama.BackColor = Color.White;
                aynalama.ForeColor = Color.Black;
            }
        }

        private void proje1C_Click(object sender, EventArgs e)
        {
            projedurumu = 1;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            projedurumu = 1;
           
            string[] portlar = SerialPort.GetPortNames();
            port.Items.Clear();
            port.Items.AddRange(portlar);
            baglantiyikes.Enabled = false;
            aynalama.Enabled = false;

        }

        private void proje2C_Click(object sender, EventArgs e)
        {
            projedurumu = 2;
            
        }

        private void proje3C_Click(object sender, EventArgs e)
        {
            projedurumu = 3;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("verigonder");
            }
        }

  
    }
}
