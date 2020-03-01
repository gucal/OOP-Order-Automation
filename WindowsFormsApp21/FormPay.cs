using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class FormPay : Form
    {
        //Nesnelerini tanımlanır.
        //-------------------------
        Check Chk = new Check();
        Credit Cdt = new Credit();
        //-------------------------
       
        public FormPay()
        {
          
            InitializeComponent();
            Order ord = new Order();
            lblToplamFiyat.Text = ord.toplamTutar.ToString();//Her şey dahil fiyat
            lblVergi.Text = ord.vergiMiktar.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Chk.name = textKüs.Text;
            Cdt.tip = textTip.Text;
            Cdt.expDate = Convert.ToInt32(textSkt.Text);
            Cdt.number= Convert.ToInt32(textKN.Text);
            // dosya yazma

            if (textKüs.Text == "")
            {
                MessageBox.Show("Lütfen İsminizi giriniz.");
            }
            if (textTip.Text == "")
            {
                MessageBox.Show("Lütfen Bana kartı Tipinizi giriniz.");
            }
            if (textSkt.Text == "")
            {
                MessageBox.Show("Lütfen Kart Son Kullanma Tai giriniz.");
            }
            if (textKN.Text == "")
            {
                MessageBox.Show("Lütfen isminizi giriniz.");
            }

            cargo pen4 = new cargo();
            pen4.MdiParent = this.MdiParent;
            pen4.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chk.bankID = Convert.ToInt32(textBox4.Text);
            Chk.name = textBox6.Text;
            cargo pen4 = new cargo();
            pen4.MdiParent = this.MdiParent;
            pen4.Show();
        }

        // Dosya yazma



        private void NakiT_Click(object sender, EventArgs e)
        {
            cargo pen4 = new cargo();
            pen4.MdiParent = this.MdiParent;
            pen4.Show();
            // Dosya yazma
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

           

            FormPay kapa = new FormPay();
            kapa.Close();
            this.Hide();

            cargo pen4 = new cargo();
            pen4.MdiParent = this.MdiParent;
            pen4.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormPay kapa = new FormPay();
            kapa.Close();
            this.Hide();



            cargo pen4 = new cargo();
            pen4.MdiParent = this.MdiParent;
            pen4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormPay kapa = new FormPay();
            kapa.Close();
            this.Hide();



            cargo pen4 = new cargo();
            pen4.MdiParent = this.MdiParent;
            pen4.Show();
        }

        private void FormPay_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
