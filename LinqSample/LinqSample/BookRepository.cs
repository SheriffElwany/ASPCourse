using System.Collections.Generic;

namespace LinqSample
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title="Ado",Price=10.2f},
                   new Book(){Title="python",Price=7.7f},
                new Book(){Title="Adobe",Price=5.7f},
                new Book(){Title="Sql",Price=15.7f},
                new Book(){Title="C#",Price=20.7f},
                  new Book(){Title="C#",Price=22.7f}

            };
        }
    }
}
