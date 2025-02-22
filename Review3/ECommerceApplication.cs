using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class ECommerceApplication
    {
        Product product2 = new Product("Chips", 0);
        Product product1 = new Product("laptop", 10);

        public void CheckStock()
        {
            try
            {
                product1.ProductStockChecking();
                product2.ProductStockChecking();
                
            }
            catch(ProductOutOfStockException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
