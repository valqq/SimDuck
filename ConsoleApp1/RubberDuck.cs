using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }
        public override void display()
        {
            Console.WriteLine("Резиновая утка");
        }
    }
}
