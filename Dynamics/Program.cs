using System;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static language:
            //type resolution at compile time: C#, Java...

            //dynamic language:
            //type resolution in run time: Pyton, Ruby, JavaScript...

            //Reflection is a way to inspect metadata about the type, axccess properties, methods...


            object sa = "test";
            Console.WriteLine(sa.GetHashCode());

            var methodInfo = sa.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            //without reflections it looks like:
            dynamic sa1 = "rewrwe";
            sa1.GetHashCode();

            sa1 = 10;

            //dynamic types are resolve in run time, var in compile time

            Console.ReadLine();
        }
    }
}
