using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Резиновая утка пищит");
        }
    }
}
