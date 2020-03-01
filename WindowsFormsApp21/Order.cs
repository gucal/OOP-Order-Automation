using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21
{
     class Order:Payment 
    {
        public int toplamTutar { get;set; }
        public int toplamAgirlik { get; set; }
        public int vergiMiktar { get; set; }
        int date { get; set; }
        string status { get; set; }

        
        public Order()
        {
            calcTax();
            calcTotalWeight();
            calcTotal();
        }
        

            public void calcTax ()//Vergi
             {
            OrderDetail od = new OrderDetail();
            vergiMiktar = 10 * od.miktar;  //Vergi toplam ücrette otomatik alınmaktadır.

        }
             
        public void calcTotalWeight() //toplam ağırlık
        {

            OrderDetail orderDetail = new OrderDetail();         
         toplamAgirlik = orderDetail.topAgirlik1;// TOPLAM AGIRLIK İLE KARGO FİYATI AYNIDIR. 1 KG = 1 TL;

       }

        public void calcTotal()//Toplam Tutar
        {
            OrderDetail od = new OrderDetail();
            toplamTutar = 0;
            
            toplamTutar += toplamAgirlik;
            toplamTutar += amount * od.miktar; ;//amount 250
        }
     
        }
            
        }




    

