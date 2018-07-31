using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add(12); //here is the example of boxing. because we convert value type into the refernce type. arraylist expects Object!!!
            list.Add("dfjsfs"); 
            list.Add(DateTime.Today); //datetime is example of value type also... another example of boxing

            int x = (int)list[0]; //unboxing


            //we can avoid boxing and unboxing with using Generic collections... They are also in System.Collection namespace.
            //We have type safety list!!!
            var list2 = new List<int>();

            list2.Add(10); //no boxing is happend because list2 expects int object!!!
        }
    }
}
