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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click_1(object sender, EventArgs e)
        {
            string adminBilgiDosyası = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Admin Giriş Bilgisi.txt";

            FileStream fs = new FileStream(adminBilgiDosyası, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string adminYazi = sr.ReadLine();

            if (adminYazi == txtAdminGiris.Text)
            {
                adminYazi = sr.ReadLine();
                if (adminYazi == txtAdminSifre.Text)
                {
                    Form2 formkapa = new Form2();
                    formkapa.Close();
                    AdminPanel calistir = new AdminPanel();
                    calistir.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Admin Girişi Yapılamadı! Bilgiler yanlış. Tekrar deneyiniz.", "Admin Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Admin Girişi Yapılamadı! Bilgiler yanlış. Tekrar deneyiniz.", "Admin Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning); }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}