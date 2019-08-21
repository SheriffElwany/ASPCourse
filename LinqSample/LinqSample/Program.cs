using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }
            foreach (var book in cheapBooks)
            {
                Console.WriteLine($"{book.Title}  {book.Price}");
            }

            //with linq Extantion methods
            Console.WriteLine("LINQ");
          var   cheapBooksLinq = books.Where(b => b.Price < 10);
            cheapBooksLinq = cheapBooksLinq.OrderBy(b => b.Title);
            foreach (var book in cheapBooksLinq)
            {
                Console.WriteLine($"{book.Title}  {book.Price}");
            }
           var  cheapBooksLinqByTitle = cheapBooksLinq.OrderBy(b => b.Price).Select(b=>b.Title);
            foreach (var item in cheapBooksLinqByTitle)
            {
                Console.WriteLine(item);
            }


            //Linq with Query Operator

            var CheaperBooks =
                from b in books
                where b.Price < 10
               orderby b.Title
                select b;


            var sbook = books.Single(b => b.Title == "python");
            Console.WriteLine(sbook.Title);

            //sbook = books.Single(b => b.Title == "pythonsssss");
            //Console.WriteLine(sbook!=null?sbook.Title:"");

            sbook = books.SingleOrDefault(b => b.Title == "pythonsssss");
            Console.WriteLine(sbook != null ? sbook.Title : "");

            var fBook=books.First(b => b.Title == "C#");
            Console.WriteLine($"{fBook.Title}-{fBook.Price}");

            var lBook = books.Last(b => b.Title == "C#");
            Console.WriteLine($"{lBook.Title}-{lBook.Price}");

            var pagedBooks = books.Skip(2).Take(3);
            Console.WriteLine("pagedBook");
            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine($"{pagedBook.Title}-{pagedBook.Price}");

            }

            pagedBooks = books.SkipWhile(b=>b.Price>10).Take(3);
            Console.WriteLine("pagedBook SkipWhile");
            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine($"{pagedBook.Title}-{pagedBook.Price}");

            }


            var highPriceBook = books.Max(b => b.Price);
            Console.WriteLine(highPriceBook);
            var totalPrice = books.Sum(b => b.Price);
        }
    }
}
