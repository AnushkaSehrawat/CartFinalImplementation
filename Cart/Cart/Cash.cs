using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Cash:Ipayment
    {
       public void pay(int cash)
        {
            Console.WriteLine("Payable Amount:" +cash);
        }
    }
}
