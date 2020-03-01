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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click_1(object sender, EventArgs e)
        {
            UrunEkle calistir = new UrunEkle();
            calistir.Show();


        }

        private void btnUrunGuncelle_Click_1(object sender, EventArgs e)
        {
            UrunGuncelle calistir = new UrunGuncelle();
            calistir.Show();
        }

        private void btnUrunSil_Click_1(object sender, EventArgs e)
        {
            UrunSil calistir = new UrunSil();
            calistir.Show();
        }

    }

}


