using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysecondobject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Please enter your address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What car do you have?");
            string modelName = Console.ReadLine();
            Console.WriteLine("Do you have pets?");
            string YesorNo = Console.ReadLine();
            bool HasPet;
            if (YesorNo == "yes")
            {
                HasPet = true;
            }
            else
            {
                HasPet = false;
            }
            Person person = new Person(Name, Address, Age, HasPet);
            Car hisorhercar = new Car(modelName);
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            Animal myHorse = new Horse();
            Animal myBird = new Bird();
            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("What is your pets name?");
            string PetName = Console.ReadLine();
            Console.WriteLine("Is " + PetName + " he or she?");
            string HeOrShe = Console.ReadLine();
            Console.WriteLine("What kind of pet you have?");
            string PetKind = Console.ReadLine();
            Console.WriteLine("\n");
            if (PetKind == "Pig" || PetKind == "pig")
            {
                myAnimal.animalSound();
                myPig.animalSound();
                person.Greeting();
                person.Bus();
                hisorhercar.Make();
            }
            else if (PetKind == "Dog" || PetKind == "dog")
            {
                myAnimal.animalSound();
                myDog.animalSound();
                person.Greeting();
                person.Bus();
                hisorhercar.Make();
            } 
            else if (PetKind == "Cat" || PetKind == "cat")
            {
                myAnimal.animalSound();
                myCat.animalSound();
                person.Greeting();
                person.Bus();
                hisorhercar.Make();
            }
            else if (PetKind == "Horse" || PetKind == "horse")
            {
                myAnimal.animalSound();
                myHorse.animalSound();
                person.Greeting();
                person.Bus();
                hisorhercar.Make();
            }
            else if (PetKind == "Bird" || PetKind == "bird")
            {
                myAnimal.animalSound();
                myBird.animalSound();
                person.Greeting();
                person.Bus();
                hisorhercar.Make();
            }
            else
            {
                Console.WriteLine("What is your pet sounds like?");
                string AniSound = Console.ReadLine();
                Console.WriteLine("Cool");
                person.Greeting();
                person.Bus();
                hisorhercar.Make();
            }
        }
    }
}
