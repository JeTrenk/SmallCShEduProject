using System;


namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is constructed. {0}", registrationNumber);

        }
    }
}
