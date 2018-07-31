using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaces and Testability
            //var orderProcessor = new OrderProcessor( new ShippingCalculator());
            //var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            //orderProcessor.Process(order);

            //Interfaces and extensibility
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Projects\\log.txt"));
            dbMigrator.Migrate();

            Console.ReadLine();
        }
    }
}
