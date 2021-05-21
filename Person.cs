using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysecondobject
{
    public class Person
    {
        public string Name;
        public string Address;
        public int Age;
        public bool HasPet;
        string HouseNo;
        string Addressfirstline;
        string Addresssecondline;
        string Addressthirdline;
        string Addressforthline;
        string Postcode;
        string Country1;
        string Country2;
       
        public Person(string Name, string Address, int Age, bool HasPet)
        {
            this.Name = Name;
            this.Address = Address;
            this.Age = Age;
            this.HasPet = HasPet;

            string[] Address1 = Address.Split(' ');
            this.HouseNo = (Address1[0]);
            this.Addressfirstline = (Address1[1]);
            this.Addresssecondline = (Address1[2]);
            this.Addressthirdline = (Address1[3]);
            this.Addressforthline = (Address1[4]);
            this.Postcode = (Address1[5]);
            this.Country1 = (Address1[6]);
            this.Country2 = (Address1[7]);
        }

        public void Greeting()
        {
            if (HasPet == true)
            {
                string Pet = "have";
                Console.WriteLine("Hi! " + this.Name + ", you are " + this.Age + " old and you " + Pet + " pets.");
                Console.WriteLine("You live in\n" + this.HouseNo + " " + this.Addressfirstline + " " + this.Addresssecondline + "\n" + this.Addressthirdline + "\n" + this.Addressforthline + " " + this.Postcode + "\n" + this.Country1 + " " + this.Country2);
            }
            else if (HasPet == false)
            {
                string Pet = "do not have";
                Console.WriteLine("Hi! " + this.Name + ", you are " + this.Age + " old and you " + Pet + " pets.");
                Console.WriteLine("You live in\n" + this.HouseNo + " " + this.Addressfirstline + " " + this.Addresssecondline + "\n" + this.Addressthirdline + "\n" + this.Addressforthline + " " + this.Postcode + "\n" + this.Country1 + " " + this.Country2);
            }
        }

        public void Bus()
        {
            string[] Area = { "Riverhead", "Albany", "Takapuna", "Kumeu", "Epsom", "Greenlane" };
            if (this.Addressthirdline == Area[0])
            {
                Console.WriteLine("Please Take Bus No 126.");
            }
            else if (this.Addressthirdline == Area[1])
            {
                Console.WriteLine("Please Take Bus No 83.");
            }
            else if (this.Addressthirdline == Area[2])
            {
                Console.WriteLine("Please Take Bus No 801.");
            }
            else if (this.Addressthirdline == Area[3])
            {
                Console.WriteLine("Please Take Bus No 125.");
            }
            else if (this.Addressthirdline == Area[4])
            {
                Console.WriteLine("Please Take Bus No 277");
            }
            else
            {
                Console.WriteLine("Please Take Bus No 309");
            }
        }
    }
}
