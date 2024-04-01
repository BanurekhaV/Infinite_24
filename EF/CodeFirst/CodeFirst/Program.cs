using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst
{
    class Program
    {
        static BooksDBContext db = new BooksDBContext();

        static void ShowAllBooks()
        {
            var book = from b in db.book
                       select b;

            foreach(var item in book)
            {
                Console.WriteLine(item.BookId + " "+ item.BookName+ " "+ item.BookPrice);
            }
        }

        static void UpdateBooks(Books b)
        {
            var bk = db.book.FirstOrDefault(b1 => b1.BookId == b.BookId);
            bk.BookPrice = 800;
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            ShowAllBooks();
            Console.WriteLine("------------");
            Books b = new Books { BookId = 2 };
            UpdateBooks(b);
            ShowAllBooks();
            Console.Read();
        }
    }
}
