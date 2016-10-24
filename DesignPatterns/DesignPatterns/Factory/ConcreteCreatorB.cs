using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ConcreteCreatorB : Creator
    {
        public override List<Product> FactoryMethod()
        {
            List<Product> products = new List<Product>();
            products.Add(new ConcreteProductC());
            products.Add(new ConcreteProductD());
            return products;
        }
    }
}
