using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Books
    {

        struct Book
        {
            public int bookId;
            public string title;
            public int price;
            public string BookType;

        }

        public enum BookTypes { Magazine, Novel, ReferenceBooks, Miscellaneous }

        public void Method() {
            Book b;
            Console.WriteLine("Enter the book details");
            Console.WriteLine("BookId:");
            b.bookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Title:");
            b.title = Console.ReadLine();
            Console.WriteLine("Price");
            b.price = Convert.ToInt32(Console.ReadLine());
            b.BookType = "";
            Console.WriteLine("Select the book type:");
            Console.WriteLine("1.Magazine");
            Console.WriteLine("2.Novel");
            Console.WriteLine("3.ReferenceBook");
            Console.WriteLine("4.Miscellaneous");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                b.BookType = BookTypes.Magazine.ToString();


            }
            else if (ch == 2)
            {
                b.BookType = BookTypes.Novel.ToString();
            }
            else if(ch == 3)
            {
                b.BookType = BookTypes.ReferenceBooks.ToString();

            }
            else if (ch == 4)
            {
                b.BookType = BookTypes.Miscellaneous.ToString();
            }
            else
            {
                Console.WriteLine("Incorrect choice enterred");
            }
         
            Console.WriteLine("The Given Details are:");
            Console.WriteLine("Id: {0}", b.bookId);
            Console.WriteLine("Title: {0}", b.title);
            Console.WriteLine("Price: {0}", b.price);
            Console.WriteLine("Type: {0}", b.BookType);
        }
    }
}
