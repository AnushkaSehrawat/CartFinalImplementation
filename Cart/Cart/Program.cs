using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Program
    {
        public static List<Item> itemsList = new List<Item>()
            {
                new Item
            {
               itemName="Abc",
               itemId=1,
               itemQuantity=30,
               itemPrice=1000,
            },
            new Item
            {
                itemName="XYZ",
               itemId=2,
               itemQuantity=50,
               itemPrice=2000,

            }

            };

        static void Main(string[] args)
        {

            
            cart cartobj = new cart();
            Booking bookingobj = new Booking();
            int opt;
            int index=0;
            int exit = 0;
            string paymentType;
            while (exit == 0)
            {
                Console.WriteLine("Enter which operation you want to perform 1: display available items 2: Add to cart 3: Remove item from cart 4:Display cart 5: clear cart 6: Total no of items in the cart 7: Purchase items from the cart");
                opt = Int32.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        {
                           
                           foreach(Item item in itemsList)
                            {
                                Console.WriteLine("index:" + index + " Id: " + item.itemId + " Name: " + item.itemName + " Quantity: " + item.itemQuantity + " Price:" + item.itemPrice);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the index of item which you want to add");
                            index = Int32.Parse(Console.ReadLine());
                            cartobj.addToCart(itemsList[index]);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the index of item from cart list which you want to remove");
                            index = Int32.Parse(Console.ReadLine());
                            cartobj.removeItemFromCart(itemsList[index]);
                            break;
                        }
                    case 4:
                        {
                            cartobj.displaycart();
                            break;
                        }
                    case 5:
                        {
                            cartobj.clearCart();
                            break;
                        }
                    case 6:
                        {
                            cartobj.TotalNoOfItems();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter the payment mode:card or Cash ");
                            paymentType = Console.ReadLine();
                            Payment pobj = new Payment();
                            Ipayment paymentMode = pobj.DeterminePaymentMode(paymentType);
                            bookingobj.CalculatePayment(paymentMode, cartobj.cartItems);
                            break;
                        }

                }

                Console.WriteLine("Do you want to exit 0: No 1: Yes");
                exit = Int32.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
