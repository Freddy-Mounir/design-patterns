using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class ConcreteCreatorA : Creator
    {
        protected override List<Product> FactoryMethod()
        {
            List<Product> products = new List<Product>();
            products.Add(new ConcreteProductA());
            products.Add(new ConcreteProductB());
            products.Add(new ConcreteProductD());
            return products;
        }
    }
}
