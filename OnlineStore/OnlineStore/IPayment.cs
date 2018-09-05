using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    interface IPayment
    {
        void Cash();
        void Online();
    }
}
