using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //polymophism = greek word that means to have many forms.
            //              Objects can be identitfied by more that one type
            //              Exmp: a dog is also: canine , animal, organism

            Car car = new Car();
            Bicyle bicyle = new Bicyle();
            Boat boat = new Boat();


            Vehicle[] vehicles = { car, bicyle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {

        }

    }
    class Car: Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Boat : Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("The bicyle is moving!");

        }
    }

    class Bicyle : Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("The boat is moving!");

        }
    }

}










