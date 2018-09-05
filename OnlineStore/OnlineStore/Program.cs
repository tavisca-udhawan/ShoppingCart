using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Program
    {

        public static void Main(string[] args)
        {
            List<Items> listItems = new List<Items>();
            Items items = new Items();
            Cart obj = new Cart();
            while (true)
            {
                Console.WriteLine("Enter option:");
                Console.WriteLine("1--Add to Cart");
                Console.WriteLine("2--Remove from Cart");
                Console.WriteLine("3--Display Cart");
                Console.WriteLine("4--Clear cart");
                Console.WriteLine("5--Exit");
                int value = Convert.ToInt32(Console.ReadLine());
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
                    obj.showItems(items, listItems);
                }
                else if (value == 4)
                {
                    listItems=obj.clearCart(listItems);
                }
                else if (value == 5)
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