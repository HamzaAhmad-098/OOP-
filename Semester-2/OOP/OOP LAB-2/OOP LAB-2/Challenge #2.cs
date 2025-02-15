using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_LAB_2
{
    class product
    {
        public string Name;
        public int ID;
        public string Category;
        public string BrandName;
        public string Country;
        public int Price;
        public product() { }
        public product(string name, int id, string category, string brandname , string country,int price)
        {
            Name = name;
            ID = id;
            Category = category;
            BrandName = brandname;
            Country = country;
            Price = price;
        }

        public void displayProducts()
        {
            Console.WriteLine("Product Name : " + Name);
            Console.WriteLine("Product ID : " + ID);
            Console.WriteLine("Category : " + Category);
            Console.WriteLine("BrandName : " + BrandName);
            Console.WriteLine("Country : "+Country);
            Console.WriteLine("Price : "+Price);
        }
        public int storeWorth(List<int> price )
        {
            int sum = 0;
            for (int i = 0; i < price.Count; i++)
            {
                sum += price[i];
            }
            return sum;
        }
    }
    internal class Challenge__2
    {
        static void Main(string[] args)
        {
            string Name;
            int ID;
            string Category;
            string BrandName;
            string Country;
            int price;
            product Products= new product();
            List<product> products = new List<product>();
            List<int> Price = new List<int>();
            while (true)
            {
                int ch;
                Console.WriteLine("1.ADD Product ");
                Console.WriteLine("2.Show Products");
                Console.WriteLine("3.Store Worth");
                Console.WriteLine("4.Exit");
                ch = int.Parse(Console.ReadLine());
                
                if (ch == 1)
                {
                    Console.WriteLine("Enter the product name ");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter the product ID ");
                    ID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter product category ");
                    Category  = Console.ReadLine();
                    Console.WriteLine("Enter Brand name  ");
                    BrandName  = Console.ReadLine();
                    Console.WriteLine("Enter the price of product ");
                    price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the country name");
                    Country = Console.ReadLine();
                    product Product  = new product( Name,  ID,  Category,  BrandName,  Country,  price);
                    products.Add(Product);
                }
                else if (ch == 2)
                {
                    if (products.Count > 0)
                    {
                        for (int i = 0; i < products.Count; i++)
                        {
                            Console.WriteLine($"Product {i + 1}");
                            products[i].displayProducts();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No product added yet ");
                    }
                }
                else if (ch == 3)
                {
                    for(int i=0; i<products.Count; i++)
                    {
                        Price.Add(products[i].Price);
                    }
                    Console.WriteLine("Total Worth of Store is : " + Products.storeWorth(Price));
                }
                else if (ch == 4)
                {
                    break;
                }
            }
        }
    }
}
