using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Не издает звуков!");
        }
    }
}
