using System;
using System.Collections;

namespace LambdaExpression
{
    class Program
    {
        private delegate int SquareHandler(int s);

        static void Main(string[] args)
        {
            //SquareHandler squareHandler = Square;
            //squareHandler = Triple;
            //Console.WriteLine(squareHandler(5));
            //Console.WriteLine(squareHandler(5));

            //Func<int, int> square = Square;

            //Lambda expression: arg => expression
            //() => expression
            //x => expression
            //(x, y, z) => expression

            //Func<int, int> square = n => n * n;
            //Console.WriteLine(square(12));
            //Console.ReadKey();

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(a => a.Price < 15);

            foreach (var b in cheapBooks)
            {
                Console.WriteLine(b.Title);
            }

            Console.ReadKey();
        }

        private static int Square(int x)
        {
            return x * x;
        }

        private static int Triple(int x)
        {
            return x * x * x;
        }

        private int s;

        int setX {
            get
            {
                return s; 
            }
            set
            {
                this.s = value;
            }
        }
    }
}
