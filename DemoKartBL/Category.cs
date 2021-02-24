using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Category
    {
        //enum Categories {electronics=1, grocery, clothing, cosmetic }

        public String categories;
        public Category()
        {
            categories = null;
        }
        public Category(String categories)
        {
            this.categories = categories;
        }
        public double CalculatePrice(int type, double price)
        {
            if (type == 1)
            {
                double totalPrice = 0;
                totalPrice = price + (price * 0.18);
                return totalPrice;
            }
            else if (type == 2)
            {
                double totalPrice = 0;
                totalPrice = price + ( price * 0.04);
                return totalPrice;
            }
            else if (type == 3)
            {
                double totalPrice = 0;
                totalPrice = price + (price * 0.07);
                return totalPrice;
            }
            else if (type == 4)
            {
                double totalPrice = 0;
                totalPrice = price +(price * 0.18);
                return totalPrice;
            }
            else
            {
                return 0;
            }
        }

    }
}

