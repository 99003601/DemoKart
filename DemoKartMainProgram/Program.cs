using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace DemoKartMainProgram
{
    class Program
    {
        static List<Product> ProductList1 = new List<Product>(10);
        static List<Product> ProductList2 = new List<Product>(10);
        static List<Product> ProductList3 = new List<Product>(10);
        static List<Product> ProductList4 = new List<Product>(10);
        static List<Product> CartList = new List<Product>(10);
        
        static void Main(string[] args)
        {
            
            Product[] ProductObj = new Product[20];
            Cart CartObj = new Cart();
            Category categoryObj = new Category();
            Payment paymentObj = new Payment();
            int num,num1,num3,num4,id;
            double TotalPrice=0, TotalPrice1 = 0, TotalPrice2 = 0, TotalPrice3 = 0, TotalPrice4 = 0;
            double GrandTotal1 = 0, GrandTotal2 = 0;
            User UserObj = new User();
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter User name");
            String UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            String Password = Console.ReadLine();
            int value = UserObj.Login(UserName, Password);
            for (int i = 0; i < 2; i++)
            {
                ProductObj[0] = new Product(1, "APPLE", 50, 7);
                ProductObj[1] = new Product(2, "ORANGE", 70, 6);
                ProductList1.Add(ProductObj[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                ProductObj[0] = new Product(3, "WATERMELON", 50, 5);
                ProductObj[1] = new Product(4, "MANGO", 60, 2);

                ProductList2.Add(ProductObj[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                ProductObj[0] = new Product(5, "PINEAPPLE", 55, 6);
                ProductObj[1] = new Product(6, "STRAWBERRY", 70, 4);

                ProductList3.Add(ProductObj[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                ProductObj[0] = new Product(7, "GRAPES", 60, 7);
                ProductObj[1] = new Product(8, "TOMATO", 40, 8);

                ProductList4.Add(ProductObj[i]);
            }

            if (value == 1)
            {

                do
                {
                    Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothing\t4.Cosmetics");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    if (Choice == 1)
                    {
                      
                        foreach (Product item in ProductList1)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if(num1==1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in ProductList1)
                            {
                                
                                if (id==item.productId)
                                {
                                    value = CartObj.AddToCart(quant);
                                    if (value == 1)
                                    {
                                        Console.WriteLine("Quantity Size Exceed The Limit\n");
                                        break;
                                    }
                                    else
                                    {
                                        TotalPrice1 = categoryObj.CalculatePrice(Choice, item.price);
                                        Product cust_cart = new Product(item.productId, item.productName, item.price, item.quantity);
                                        CartList.Add(cust_cart);                                     
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }
                                }
                            }
                        }
    
                    }
                    else if(Choice==2)
                    {
                        foreach (Product item in ProductList2)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in ProductList2)
                            {

                                if (id == item.productId)
                                {
                                    value = CartObj.AddToCart(quant);
                                    if (value == 1)
                                    {
                                        Console.WriteLine("Quantity Size Exceed The Limit\n");
                                        break;
                                    }
                                    else
                                    {
                                        TotalPrice2 = categoryObj.CalculatePrice(Choice, item.price);
                                        Product cust_cart = new Product(item.productId, item.productName, item.price, item.quantity);
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }
                                }
                            }
                        }

                    }
                
                    else if(Choice==3)
                    {
                        foreach (Product item in ProductList3)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in ProductList3)
                            {

                                if (id == item.productId)
                                {
                                    value = CartObj.AddToCart(quant);
                                    if (value == 1)
                                    {
                                        Console.WriteLine("Quantity Size Exceed The Limit\n");
                                        break;
                                    }
                                    else
                                    {
                                        TotalPrice3 = categoryObj.CalculatePrice(Choice, item.price);
                                        Product cust_cart = new Product(item.productId, item.productName, item.price, item.quantity);
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }
                                }
                            }
                        }
                    }
                    else if(Choice==4)
                    {
                        
                        foreach (Product item in ProductList4)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in ProductList4)
                            {

                                if (id == item.productId)
                                {
                                    value = CartObj.AddToCart(quant);
                                    if (value == 1)
                                    {
                                        Console.WriteLine("Quantity Size Exceed The Limit\n");
                                        break;
                                    }
                                    else
                                    {
                                        TotalPrice4 = categoryObj.CalculatePrice(Choice, item.price);
                                        Product cust_cart = new Product(item.productId, item.productName, item.price, item.quantity);
                                        CartList.Add(cust_cart);
                                        Console.WriteLine("Add To cart Is Successfull\n");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                    Console.WriteLine("1.Revisit\t2.Display Cart And Payment");
                    num = Convert.ToInt32(Console.ReadLine());

                } while (num==1);
            }
            else
            {
                Console.WriteLine("User Name and Passwords are Not matched\n");
            }


            foreach (Product item in CartList)
            {

                Console.WriteLine("Product id : " + item.productId);
                Console.WriteLine("Product Name : " + item.productName);
                Console.WriteLine("Product Price : " + item.price);
                Console.WriteLine("Product Quantity : " + item.quantity);
                Console.WriteLine("\n");
            }

            do
            {
                Console.WriteLine("1.Delete cart List\t2.Payment");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 1)
                {
                    Console.WriteLine("Enter Product Id To Delete");
                    int PI = Convert.ToInt32(Console.ReadLine());
                    foreach (Product item in CartList)
                    {
                        if (PI == item.productId)
                        {
                            CartList.Remove(item);
                            break;
                        }


                    }
                }
                else
                {
                    Console.WriteLine("Product not available in cart");
                }
                Console.WriteLine("1.Remove Another Cart\t2.Payment");
                num3 = Convert.ToInt32(Console.ReadLine());
            } while (num3==1);

            foreach (Product item in CartList)
            {
                Console.WriteLine("Updated Cart List");
                Console.WriteLine("Product id : " + item.productId);
                Console.WriteLine("Product Name : " + item.productName);
                Console.WriteLine("Product Price : " + item.price);
                Console.WriteLine("Product Quantity : " + item.quantity);
                Console.WriteLine("\n");
            }

            TotalPrice = TotalPrice1 + TotalPrice2 + TotalPrice3 + TotalPrice4;
            Console.WriteLine("Enter Payment method");
            Console.WriteLine("1.ByCash\t2.ByCard");
            num4 = Convert.ToInt32(Console.ReadLine());
            if(num4==1)
            {
                GrandTotal1 = paymentObj.CalculateCGST(num4, TotalPrice);
                Console.WriteLine("Central GST is : "+GrandTotal1);
                GrandTotal2 = paymentObj.CalculateSGST(num4, TotalPrice);
                Console.WriteLine("State GST is : "+GrandTotal2);
            }
            else if(num4==2)
            {
                GrandTotal1 = paymentObj.CalculateCGST(num4, TotalPrice);
                Console.WriteLine("Central GST is : " + GrandTotal1);
                GrandTotal2 = paymentObj.CalculateSGST(num4, TotalPrice);
                Console.WriteLine("State GST is : " + GrandTotal2);
            }



            Console.WriteLine("Thank You For Visiting.....................................");
        }
    }
}

