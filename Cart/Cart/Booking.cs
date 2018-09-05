using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Booking
    {
        int totalPrice = 0;
        public void CalculatePayment(Ipayment payment,List<Item> itemsList)
        {
            totalPrice = 0;
            foreach (Item item in itemsList)
            {
                totalPrice += item.itemPrice;
            }
            payment.pay(totalPrice);
        }
    }
}
