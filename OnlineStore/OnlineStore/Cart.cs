using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Cart
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
        public void showItems(Items items, List<Items> listItems)
        {
            //Show items in a cart
            if (listItems.Count > 0)
            {
                Console.WriteLine("Items in cart are:");
                for (int index = 0; index < listItems.Count; index++)
                {
                    Console.WriteLine("ID: " + listItems[index].id);
                    Console.WriteLine("Name: " + listItems[index].name);
                    Console.WriteLine("Price: " + listItems[index].price);
                    Console.WriteLine("Quantity: " + listItems[index].quantity);
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
            return listItems;
        }
        public int TotalPriceInCart(List<Items> listItems)
        {
            int sum = 0;
            for (int index = 0; index < listItems.Count; index++)
            {
                sum += ((listItems[index].price) * (listItems[index].quantity));
            }
            return sum;
    }
}