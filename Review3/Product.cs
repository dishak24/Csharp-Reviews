using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Review3
{
    internal class Product
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }

        public Product(string name, int stock)
        {
            ProductName = name;
            Stock = stock;
        }

        public void ProductStockChecking()
        {
            if (Stock == 0)
            {
                throw new ProductOutOfStockException($"Product {ProductName} is out of stock !!!");
            }
            else
            {
                Console.WriteLine($"Product {ProductName} with stock {Stock} available!");
            }
                
        }
    }
}
