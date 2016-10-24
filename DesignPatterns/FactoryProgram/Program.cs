using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory;

namespace FactoryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creatorOne = new ConcreteCreatorA();
            Creator creatorTwo = new ConcreteCreatorB();

            // Should Print Types of ABD
            foreach (Product p in creatorOne.Products)
            {
                Console.WriteLine(p.GetType().ToString());
            }

            // Shoudl Print Types of CD
            foreach (Product p in creatorTwo.Products)
            {
                Console.WriteLine(p.GetType().ToString());
            }
        }
    }
}
