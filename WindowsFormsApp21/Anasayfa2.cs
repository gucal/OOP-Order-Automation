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
    public partial class Anasayfa2 : Form
    {
        public Anasayfa2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer Cust = new Customer();
            
            Cust.name = textName.Text;
            Cust.adress = textAdress.Text;
            if(textName.Text == "")
            {
                MessageBox.Show("Lütfen isminizi giriniz.");
            }
            if (textAdress.Text == "")
            {
                MessageBox.Show("Lütfen Adressinizi giriniz giriniz.");
            }


            if (textName.Text != "")
            {
                if (textAdress.Text != "")
                {
                    Anasayfa2 kapa = new Anasayfa2();
                    kapa.Close();
                    this.Hide();
                    FormPay pen3 = new FormPay();
                    pen3.MdiParent = this.MdiParent;
                    pen3.Show();


                }
            }



        }

        private void Anasayfa2_Load(object sender, EventArgs e)
        {

        }
    }
}
