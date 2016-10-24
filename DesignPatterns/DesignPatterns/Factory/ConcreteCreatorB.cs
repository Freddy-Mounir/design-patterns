using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class ConcreteCreatorB : Creator
    {
        protected override List<Product> FactoryMethod()
        {
            List<Product> products = new List<Product>();
            products.Add(new ConcreteProductC());
            products.Add(new ConcreteProductD());
            return products;
        }
    }
}
