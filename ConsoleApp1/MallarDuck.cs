using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MallarDuck : Duck
    {
        public MallarDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("Мандариновая уточка");
        }
    }
}
