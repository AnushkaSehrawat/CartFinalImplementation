using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    interface ICartOperations
    {
        void DisplayCart();
        void addToCart(Item item);
        void removeItemFromCart(Item item);
        void displaycart();
        void clearCart();
        void buynow(Ipayment payment);
    }
}
