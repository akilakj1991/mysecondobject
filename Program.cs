using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysecondobject
{
    class Vehicle
    {
        public string brand1 = "Ford";  
        public int engineHP1 = 650;
        public int engineHP2 = 600;
        public string brand2 = "Dodge";
        public int engineHP3 = 675;
        public int engineHP4 = 650;
        public string brand3 = "Chevrolet";
        public int engineHP5 = 812;
        public int engineHP6 = 704;
        public int engineHP7 = 950;

        public void honk0()           
        {
            Console.WriteLine("Your car honk like Pooq, pooq!");
        }
        public void honk1()
        {
            Console.WriteLine("Your car honk like Peep, peep!");
        }
    }

    class Car : Vehicle  
    {
        public string modelName; 

        public Car(string modelName)
        {
            this.modelName = modelName;
        }

    public void Make()
        {
            if(modelName == "Mustang" || modelName == "mustang" || modelName == "F150" || modelName == "f150")
            {
                Console.WriteLine("Your car make is " + brand1 + ".");
                if (modelName == "Mustang" || modelName == "mustang")
                {
                    Console.WriteLine("Your car makes " + engineHP1 + "HP.");
                }
                else
                {
                    Console.WriteLine("Your car makes " + engineHP2 + "HP.");
                }
                honk0();
            }
            else if(modelName == "Corvette" || modelName == "corvette" || modelName == "Camaro" || modelName == "camaro")
            {
                Console.WriteLine("Your car make is " + brand3 + ".");
                if (modelName == "Corvette" || modelName == "corvette")
                {
                    Console.WriteLine("Your car makes " + engineHP3 + "HP.");
                }
                else
                {
                    Console.WriteLine("Your car makes " + engineHP4 + "HP.");
                }
                honk0();
            }
            else if(modelName == "Challenger" || modelName == "challenger" || modelName == "Charger" || modelName == "charger" || modelName == "Viper" || modelName == "vioer")
            {
                Console.WriteLine("Your car make is " + brand2 + ".");
                if (modelName == "Challenger" || modelName == "challenger")
                {
                    Console.WriteLine("Your car makes " + engineHP5 + "HP.");
                }
                else if (modelName == "Charger" || modelName == "charger")
                {
                    Console.WriteLine("Your car makes " + engineHP6 + "HP.");
                }
                else
                {
                    Console.WriteLine("Your car makes " + engineHP7 + "HP.");
                }
                honk0();
            }
            else
            {
                Console.WriteLine("You do not own an American Car.");
                honk1();
            }
        }
    }
}
