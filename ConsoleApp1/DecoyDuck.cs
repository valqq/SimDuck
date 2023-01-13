using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
        public override void display()
        {
            Console.WriteLine("утка приманка");
        }
    }
}
