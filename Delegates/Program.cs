using System;
using System.IO;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //in .net there are two different built in delegates types: Action and Func
            //difference between two of them are in the fact that funct return result, action asumes void return type!!!
            //till 16 input parameters

            //delegates are pointers to the methods, they know how to call methods
            var processor = new PhotoProcessor();
            processor.Process("photo.jpg");

        }
    }
}
