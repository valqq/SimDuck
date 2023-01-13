using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MallarDuck duck1 = new MallarDuck();
            duck1.display();
            duck1.swim();
            duck1.performQuack();
            duck1.performFly();

            RedheadDuck duck2 = new RedheadDuck();
            duck2.display();
            duck2.swim();
            duck2.performQuack();
            duck2.performFly();

            RubberDuck duck3 = new RubberDuck();
            duck3.display();
            duck3.swim();
            duck3.performQuack();
            duck3.performFly();

            DecoyDuck duck4 = new DecoyDuck();
            duck4.display();
            duck4.swim();
            duck4.performQuack();
            duck4.performFly();

            ModelDuck duck5 = new ModelDuck();
            duck5.display();
            duck5.swim();
            duck5.performQuack();
            duck5.performFly();
            duck5.setFlyBehavior(new FlyRocketPowered());
            duck5.performFly();



        }
    }
}
