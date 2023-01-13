using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Я не лечу!");
        }
    }
}
