using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_05
{
    class Library
    {
        enum ACTIONS { STOP, FIRST, SECOND, THIRD, FOURTH, FIFTH };
        protected List<Book> lib = new List<Book>();
        public void Init()
        {
            bool flag = true;
            string shouldContinue;
            Console.WriteLine("Init library: ");

            do
            {
                Console.Write("Add new book? (yes/no): ");
                shouldContinue = Console.ReadLine();
                if (shouldContinue == "no")
                {
                    flag = false;
                }
                else
                {
                    Book book = new Book();
                    this.lib.Add(book);
                }
            } while (flag);
        }

        public void FindBook(List<Book> lib, int id)
        {
            Console.WriteLine("\nContains: Part with Id=1734: {0}", lib.Contains(new Book { bookID = id } ));
        }

        public Library()
        {
            Init();

            Console.WriteLine("Choose action: ");
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case (int)ACTIONS.FIRST:
                    FindBook(lib, 2);
                    break;
                case (int)ACTIONS.SECOND:
                    Console.WriteLine("Compare");
                    break;
                default:
                    Console.WriteLine("It's too much");
                    break;
            }
        }
    }
}
