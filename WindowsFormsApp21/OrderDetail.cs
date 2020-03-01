using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21
{
   public class OrderDetail : Item
    {
       public int  miktar { get;set; }
        
       public int vergiDurumu { get; set; }
       public int topAgirlik1 { get; set; }
      
        public OrderDetail()
        {
                     
             calcAgirlik();
           
        }

        void  calcAgirlik( )
        {

            
            topAgirlik1 = 1; //Sabit kalsın
            topAgirlik1 *= (miktar * kAgirlik);
        }

       
    }
    
}
