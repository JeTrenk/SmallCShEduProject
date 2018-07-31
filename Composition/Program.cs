using System;

namespace Composition
{
    class Program
    {
        //Has-A
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
        }

        
    }

   
}
