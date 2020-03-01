using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp21;
using System.IO;

namespace WindowsFormsApp21
{
    public partial class Anasayfa : Form 
    {
        int sayi;
        OrderDetail od = new OrderDetail();
        public Anasayfa()
        {            
            InitializeComponent();
            string urunadioku = @"C:\Users\fatih\Desktop\Sipariş Otomasyonu\Ürün Bilgileri.txt";
            FileStream fs = new FileStream(urunadioku, FileMode.Open, FileAccess.Read); //Dosya yolunu gösterir.
            StreamReader sr = new StreamReader(fs);

            string yazi = sr.ReadLine();
            lblUrunAdi.Text = yazi;
            yazi = sr.ReadLine();
            lblStok.Text = yazi; //Dosyadaki okumayı aşağı satıra alır.
            sr.Close();
            fs.Close();
            
            Credit n1 = new Credit();

            lblToplamTutar.Text = n1.amount.ToString(); //250 TL

        }
             
        
        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetail od = new OrderDetail();
            od.kiloAlmak();
           
                     
           
            Anasayfa kapa = new Anasayfa();
            kapa.Close();
            this.Hide();
           
            Anasayfa2 pen2 = new Anasayfa2();
            pen2.MdiParent = this.MdiParent;
            pen2.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            od.kiloAlmak();
            int.TryParse(textBox1.Text, out sayi);
            od.miktar = sayi;
            MessageBox.Show("", od.miktar.ToString()) ;
            label9.Text = sayi.ToString();
        }


    }
}
