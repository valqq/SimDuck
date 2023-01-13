using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
        public override void display()
        {
            Console.WriteLine("модель утки");
        }
    }
}
