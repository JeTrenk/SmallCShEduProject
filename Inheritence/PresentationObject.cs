using System;

namespace Inheritence
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy() {
            Console.WriteLine("Copy...");
        }

        public void Duplicate() {
            Console.WriteLine("Duplicate...");
            Console.WriteLine("Duplicate...");
        }
    }
}
