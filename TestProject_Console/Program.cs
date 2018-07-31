using System;
using System.Collections.Generic;

namespace TestProject_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        //class that has semantic of collection, list or dictionary, you can improve code by implementing Indexers. 
        //It is easier to access collection members
        public class HttpCookie
        {
            private readonly Dictionary<string, string> _dictionary;
            
            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }

            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }
    }
}
