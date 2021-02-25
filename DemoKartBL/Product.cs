using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Product
    {
        //public int productId;
        //public String productName;
        //public int quantity;
        //public double price;
        //Category categoryObj = new Category();
        public int productId { get; set; }
        public String productName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public Product(string productName)
        {
            productId = 0;
            productName = null;
            quantity = 0;
            price = 0;
        }
        public Product(int productId, String productName, double price, int quantity)
        {
            this.productId = productId;
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
