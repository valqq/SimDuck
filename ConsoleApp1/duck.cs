using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void performFly()
        {
            flyBehavior.fly();
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void swim()
        {
            Console.WriteLine("Я плыву!");
        }
        public abstract void display();
    }

}
