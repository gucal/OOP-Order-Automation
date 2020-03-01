using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21
{
    public class Item 
    {
        public int kAgirlik { get; set; }
        public string Aciklama { get; set; }


        public void kiloAlmak () {
          
        }
        public Item()
        {
            int miktarfiyat; //Birim fiyat;
            kAgirlik = 10;
            Credit a1 = new Credit();
            miktarfiyat = a1.amount; // 1 Tanesinin fiyatı
        }



            
            
            
            

        
        


    }
}
