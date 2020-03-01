using WindowsFormsApp21;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Dosyala işleminin yapılması için gereken Kütüphane!

namespace Order_Ottomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e) //MÜŞTERİ KAYIT BUTONU
        {
            //LOGIN DOSYASI OLUSTUR     //DOSYANIN KAYDOLACAĞI KLASÖR UZANTISI
            string dosyaKayit = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Müşteri Kaydı.txt";

            FileStream fs = new FileStream(dosyaKayit, FileMode.OpenOrCreate, FileAccess.Write);//dosyanın yolu
                                                                                                   //dosyanın varsa açılacağını
                                                                                                   //yoksa oluşturulacağını
                                                                                                   //Dosyanın yazılacağını

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(txtKAdi.Text); //Dosyaya yazdırma işlemi.
            sw.WriteLine(txtSifre.Text);
            sw.WriteLine(txtTelefonNo.Text);

            sw.Flush();

            sw.Close(); //sw fonksiyonunu kapat.
            fs.Close(); //fs nesnesini kapat.
            MessageBox.Show("Müşteri Kaydı Yapıldı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        //LOGIN KARSILASTIR
        private void btnGiris_Click_1(object sender, EventArgs e) //MÜŞTERİ GİRİŞ BUTONU
        {
            string dosyaKayit = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Müşteri Kaydı.txt";

            FileStream fs = new FileStream(dosyaKayit, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string yazi = sr.ReadLine();
            if (yazi == txtKGiris.Text)
            {
                yazi = sr.ReadLine();
                if (yazi == txtGirisSifre.Text)
                {
                    Form1 kapa = new Form1();
                    kapa.Close();
                    this.Hide();

                    Anasayfa calistir = new Anasayfa();
                    calistir.Show();
                   
                                       
                }
                else { MessageBox.Show("Giriş başarısız", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Giriş başarısız", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            sr.Close();
            fs.Close();
        }

     

        private void btnAdminGiris_Click_1(object sender, EventArgs e)
        {
            Form1 formkapa = new Form1(); // Form1 kapanır.
            formkapa.Close();
            this.Hide();

            Form2 calistir = new Form2();
            calistir.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}