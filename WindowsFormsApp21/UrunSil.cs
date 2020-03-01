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
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
        }

        private void btnUrunSil_Click_1(object sender, EventArgs e)
        {

            urunGuncelleOku();

        }
        private void urunGuncelleOku()
        {
            string urunDosyasi = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Ürün Bilgileri.txt";
            FileStream fs = new FileStream(urunDosyasi, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string urunGuncelle = sr.ReadLine();

            if (urunGuncelle == txtSilinecekUrun.Text)
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

            int a = txtSilinecekUrun.TextLength;//URUN ISIM UZUNLUGU

            FileStream fw = new FileStream(urunDosyasi, FileMode.Open, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fw);
            for (int i = 0; i <= a; i++)//URUN SİLME İSLEMİ
            {
                sw.WriteLine("");
            }
            sw.Flush();
            sw.Close();
            fw.Close();
            MessageBox.Show("Ürün Başarıyla Silindi!");
        }

        private void UrunSil_Load(object sender, EventArgs e)
        {

        }
    }
}