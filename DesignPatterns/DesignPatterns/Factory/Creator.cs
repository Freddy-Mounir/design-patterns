using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
   abstract public class Creator
    {
        public List<Product> Products;
        public Creator()
        {
            Products = FactoryMethod();
        }
       abstract public List<Product> FactoryMethod();
    }
}
