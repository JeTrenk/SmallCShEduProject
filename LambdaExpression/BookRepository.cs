using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Price=12, Title="Title 1" },
                new Book(){Price=17, Title="Title 2" },
                new Book(){Price=4, Title="Title 3" }
            };
        }
    }
}
