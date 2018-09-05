using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
     interface IProduct
    {
        List<Items> AddToCart(List<Items> listItems, Items items);
        List<Items> RemoveFromCart(int id, List<Items> listItems, Items items);
        void showItems( List<Items> listItems);
        List<Items> clearCart(List<Items> listItems);
        int TotalPriceInCart(List<Items> listItems);
    }
}
