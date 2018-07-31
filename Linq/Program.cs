using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ query Operators
            var cheapers = from b in books //always the first
                           where b.Price < 15
                           orderby b.Title
                           select b.Title; //always the last


            //LINQ extension methods
            var cheapBooks = books
                .Where(a => a.Price < 15)
                .OrderBy(a => a.Title)
                .Select(b => b.Title + b.Price);


            books.Single(b => b.Title.Equals("Title 3")); //Single() return only and only the one object; if there isn't object like this, app thorws exception
                                                          //SingleOrDefault() will return null if there is not equilant object, no exception

            books.First(c => c.Title == "Title 1");//First() returns the fist on the collection that satisfies this condition
                                                   // FirstOrDefault() return default value instead of exception

            books.Last(d=>d.Title=="Title 2"); //Last() or LastOrDefault()

            books.Skip(1).Take(2);//skip the first one and take following 2

            var count = books.Count();//number of items in collection

            var mostexpensiveBook = books.Max(e => e.Price);

            foreach(var b in cheapBooks)
            {
                Console.WriteLine(b);
            }

            Console.ReadKey();
        }
    }
}
