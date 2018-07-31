using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book() { Isbn = "123321", Title = "Test" };
            GenericList<Book> books = new GenericList<Book>();

            books.Add(new Book());
        }
    }

    public class BookList
    {
        public void Add(Book book)
        {

        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericList<T> where T : Book
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
         
    }

}
