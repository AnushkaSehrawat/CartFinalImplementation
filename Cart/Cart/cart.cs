using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class cart:ICartOperations
    {
        Program obj = new Program();
        public List<Item> cartItems = new List<Item>();
        Item itemObject = new Item();
        int totalPrice = 0;
        int index = 0;
        int evaluate = 0;


       
       public void DisplayCart()
        {
            index = 0;
            foreach(Item item in cartItems)
            {
                Console.WriteLine("index:"+index+" Id: "+item.itemId+" Name: "+ item.itemName+" Quantity: "+ item.itemQuantity+" Price:"+ item.itemPrice);
                index++;
            }
        }
        public void TotalNoOfItems()
        {
            Console.WriteLine( "The total no of items in the cart are: "+cartItems.Count);
        }


        public void addToCart( Item item)
        {

            cartItems.Add(item);
            Console.WriteLine("Item successfully added to cart");
            
        }

        public void removeItemFromCart(Item item)
        {
            evaluate = 0;
            foreach (Item items in cartItems)
            {
                if (item.itemId == items.itemId)
                {

                    cartItems.Remove(item);
                    Console.WriteLine("The item is successfully added to the cart.");
                    evaluate++;
                }
            }
            if (evaluate == 0)
            {
                Console.WriteLine("The item does not exists in the cart.");
            }
           
            
        }

        public void displaycart()
        {
            index = 0;
           foreach(Item item in cartItems)
            {
                Console.WriteLine("index:" + index + " Id: " + item.itemId + " Name: " + item.itemName + " Quantity: " + item.itemQuantity + " Price:" + item.itemPrice);
                index++;
            }
        }

        public void clearCart()
        {
            cartItems.Clear();
            Console.WriteLine("Cart sucessfully cleared");
        }

     

        public void buynow(Ipayment payment)
        {
            totalPrice = 0;
            foreach(Item item in cartItems)
            {
                totalPrice += item.itemPrice;
            }
            payment.pay(totalPrice);
 
        }

        

    }
}
