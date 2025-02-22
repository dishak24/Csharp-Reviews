using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException (string msg) : base(msg)
        {

        }
    }
}
