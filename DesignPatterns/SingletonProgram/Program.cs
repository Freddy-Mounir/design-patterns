using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Singleton;

namespace SingletonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton firstObject = Singleton.CreateSingleton();
            Singleton secondObject = Singleton.CreateSingleton();

            // both objects should equal each other
            if (firstObject == secondObject)
            {
                Console.WriteLine("first object equal second object , singleton succeeded");
            }
            else
            {
                Console.WriteLine("Singleton failed");
            }
        }
    }
}
