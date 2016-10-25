using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton _singletonObject;
        protected Singleton()
        {
        }

        public static Singleton CreateSingleton()
        {
            if (_singletonObject == null)
            {
                _singletonObject = new Singleton();
            }
           return _singletonObject;
        }
    }
}
