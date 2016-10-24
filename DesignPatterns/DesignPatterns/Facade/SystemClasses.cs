using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
   public class Facade
    {
        private SubSystemOne _subSystemOne;
        private SubSystemTwo _subSystemTwo;
        private SubSystemThree _subSystemThree;
        public Facade()
        {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
        }

        public void MethodOne()
        {
            _subSystemOne.MethodA();
            _subSystemTwo.MethodB();
        }

        public void MethodTwo()
        {
            _subSystemThree.MethodC();
        }
    }
    class SubSystemOne
    {
        public void MethodA()
        {
            Console.WriteLine("Method A Subsystem One Called");
        }
    }
    class SubSystemTwo
    {
        public void MethodB()
        {
            Console.WriteLine("Method B Subsystem Two Called");
        }
    }
    class SubSystemThree
    {
        public void MethodC()
        {
            Console.WriteLine("Method C Subsystem Three Called");
        }
    }
}
