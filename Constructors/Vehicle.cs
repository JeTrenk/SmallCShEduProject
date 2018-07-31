using System;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is constructed.");
        //}

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is constructed. {0}", registrationNumber);
        }
    }
}
