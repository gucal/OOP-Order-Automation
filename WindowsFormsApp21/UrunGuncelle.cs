using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Order_Ottomation
{
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {

            urunGuncelleOku();

        }
        private void urunGuncelleOku()
        {
            string urunDosyasi = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Ürün Bilgileri.txt";
            FileStream fs = new FileStream(urunDosyasi, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string urunGuncelle = sr.ReadLine();

            if (urunGuncelle == txtGuncellenecekUrun.Text)
            {
                sr.Close();
                fs.Close();
                urunGuncelleYaz();
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı! Tekrar Deneyiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sr.Close();
                fs.Close();
            }


        }
        private void urunGuncelleYaz()
        {
            string urunDosyasi = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Ürün Bilgileri.txt";


            FileStream fw = new FileStream(urunDosyasi, FileMode.Open, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fw);

            sw.WriteLine(txtGuncellenecekUrunYeniAdi.Text);
            sw.WriteLine(txtUrunGuncelAdedi.Text);
            sw.WriteLine("");//Dosyada satır kayması için eklendi.

            sw.Flush();
            sw.Close();
            fw.Close();
            MessageBox.Show("Ürün Başarıyla Güncellendi!");


        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}

