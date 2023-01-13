using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("Красноголовый нырок");
        }
    }
}
