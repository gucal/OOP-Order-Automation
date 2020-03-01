using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21
{
    abstract class Payment
    {

       public int amount { get; set; }

      
      public Payment()
        {

                     
            amount = 250;
        }
      
    }
}
