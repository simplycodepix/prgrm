using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_05
{
    class Book
    {
        public int bookID;
        protected string author, title, genre;
        protected int pagesCount;
        protected DateTime publishingDate;

        public Book()
        {
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Title of the book: ");
            title = Console.ReadLine();
            Console.Write("Genre: ");
            genre = Console.ReadLine();
            Console.Write("Pages count: ");
            pagesCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Book code: ");
            bookID = Convert.ToInt32(Console.ReadLine());
            Console.Write("The year of publishing: (day/month/year): ");
            publishingDate = DateTime.Parse(Console.ReadLine());
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Book code: {bookID}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Pages count: {pagesCount}");
            Console.WriteLine($"The year of publishing: {publishingDate.ToString("dd/MM/yyyy")}");
        }
    }
}
