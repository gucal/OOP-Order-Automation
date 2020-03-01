using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21
{

    class Credit  :Payment
    {
       public int number { get; set; }
       public  string tip { get; set; }
       public int expDate { get; set; }
       
        void authorized()
        {
            //DOSYA OKUMA
        }
        

    }
}
