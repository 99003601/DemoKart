using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class Order : User
    {
        public String deliveryAddress;
        public int pinCode;

        public Order()
        {

        }
        public Order(String deliveryAddress, int pinCode,String firstName,String lastName,int mobileNo)
        {
            this.deliveryAddress = deliveryAddress;
            this.pinCode = pinCode;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;

        }
    }
}

