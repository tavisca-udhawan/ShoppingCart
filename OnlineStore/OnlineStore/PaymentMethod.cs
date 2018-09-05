using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class PaymentMethod:IPayment
    {
        public void Cash()
        {
            //cash payment
            Console.WriteLine("Order placed Successfully by cash");
        }
         public void Online()
        {
            //online payment
            Console.WriteLine("Order placed Successfully by Debit card");
    }
        
    }
}
