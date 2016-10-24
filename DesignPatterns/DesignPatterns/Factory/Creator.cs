using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
   abstract class Creator
    {
        List<Product> Products;
        public Creator()
        {
            Products = FactoryMethod();
        }
       abstract protected List<Product> FactoryMethod();
    }
}
