using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;
using DesignPatterns.Facade;

namespace FacadeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facadeObject = new Facade();
            facadeObject.MethodOne();
            facadeObject.MethodTwo();
        }
    }
}
