using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Cart : IProduct
    {
       public List<Items> AddToCart(List<Items> listItems, Items items)
        {
            //Adding item to cart
            listItems.Add(items);
            Console.WriteLine("Item added successfully");
            return listItems;
        }
        public List<Items> RemoveFromCart(int id, List<Items> listItems, Items items)
        {
            //removing item from cart
            for (int check = 0; check < listItems.Count; check++)
            {
                if (listItems[check].id == id)
                {
                    listItems.Remove(listItems[check]);
                    Console.WriteLine("Item removed from cart successfully");
                }
            }
            return listItems;
        }
        public void showItems(List<Items> listItems)
        {
            //Show items in a cart
            if (listItems.Count > 0)
            {
                Console.WriteLine("Items in cart are:");
                foreach(var Items in listItems)
                {
                    Console.WriteLine("ID: " + Items.id);
                    Console.WriteLine("Name: " + Items.name);
                    Console.WriteLine("Price: " +Items.price);
                    Console.WriteLine("Quantity: " + Items.quantity);
                    Console.WriteLine("---------------------------------------");
                }
              
            }
            else
            {
                Console.WriteLine("Cart is Empty");
            }
        }
        public List<Items> clearCart(List<Items> listItems)
        {
            //clear cart
            listItems.Clear();
            Console.WriteLine("Cart is Empty");
            return listItems;
        }
        public int TotalPriceInCart(List<Items> listItems)
        {
            //calculate total amount in cart
            int sum = 0;
            for (int index = 0; index < listItems.Count; index++)
            {
                sum += ((listItems[index].price) * (listItems[index].quantity));
            }
            return sum;
        }
    }
}