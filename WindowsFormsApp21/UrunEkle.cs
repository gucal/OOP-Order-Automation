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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click_1(object sender, EventArgs e)
        {
            string urunDosyasi = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Ürün Bilgileri.txt";

            FileStream fs = new FileStream(urunDosyasi, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(txtUrunAdi.Text);
            sw.WriteLine(txtUrunAdedi.Text);
            sw.WriteLine(""); //Satır kayması için eklendi

            sw.Flush();
            sw.Close();
            fs.Close();

            MessageBox.Show("Ürün başarıyla eklendi", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}