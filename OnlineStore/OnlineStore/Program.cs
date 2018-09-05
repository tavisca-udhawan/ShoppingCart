using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Program
    {
        static List<Items> listItems = new List<Items>();
        public static void Main(string[] args)
        {
            PaymentMethod payment = new PaymentMethod();
            Cart obj = new Cart();
            while (true)
            {
                Items items = new Items();
                Console.WriteLine("Enter option:");
                Console.WriteLine("1--Add to Cart");
                Console.WriteLine("2--Remove from Cart");
                Console.WriteLine("3--Display Cart");
                Console.WriteLine("4--Total Amount in Cart");
                Console.WriteLine("5--Proceed to Payment");
                Console.WriteLine("6--Clear cart");
                Console.WriteLine("7--Exit");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (value == 1)
                {
                    Console.WriteLine("Enter ID:");
                    items.id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name:");
                    items.name = Console.ReadLine();
                    Console.WriteLine("Enter Price:");
                    items.price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Quantity:");
                    items.quantity = Convert.ToInt32(Console.ReadLine());
                     listItems=obj.AddToCart(listItems, items);
                }
                else if (value == 2)
                {
                    Console.WriteLine("Enter ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    listItems=obj.RemoveFromCart(id, listItems, items);
                }
                else if (value == 3)
                {
                    obj.showItems(listItems);
                }
                else if (value == 4)
                {
                    int total = obj.TotalPriceInCart(listItems);
                    Console.WriteLine("Total Amount: " + total);
                }
                else if (value == 5)
                {
                    Console.WriteLine("Enter Payment method:");
                    Console.WriteLine("1--Cash");
                    Console.WriteLine("2--Online");
                    Console.WriteLine("Enter Option");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                        payment.Cash();
                    else if (option == 2)
                        payment.Online();
                    else
                        Console.WriteLine("Invalid choice");
                }
                else if (value == 6)
                {
                    listItems=obj.clearCart(listItems);
                }
                else if (value == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");                }
            }
        }
    }
}