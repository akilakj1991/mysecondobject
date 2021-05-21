using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysecondobject
{
    public class Animal
    { 
        public virtual void animalSound()
        {
            Console.Write("Your pet sounds like ");
        }
    }

    class Pig : Animal  
    {
        public override void animalSound()
        {
            Console.Write("Wee Wee!!\n");
        }
    }

    class Dog : Animal 
    {
        public override void animalSound()
        {
            Console.Write("Bow Bow!!\n");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.Write("Meow Meow!!\n");
        }
    }

    class Horse : Animal
    {
        public override void animalSound()
        {
            Console.Write("Heeeheeeheee!!\n");
        }
    }

    class Bird : Animal
    {
        public override void animalSound()
        {
            Console.Write("Pitatu!!\n");
        }
    }
}
