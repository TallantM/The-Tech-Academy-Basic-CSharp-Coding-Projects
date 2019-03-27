using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine(fullName);
        }
        public void Quit()
        {
            Console.WriteLine("To exit, press enter.");
            Console.ReadLine();
        }
    }
}

