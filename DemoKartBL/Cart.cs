using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Cart
    {
        public int cartId;


        public int AddToCart(int Quantity)
        {
            if (Quantity > 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}

