using System;

namespace _3_Inheritance
{
    class Printer
    {
        public void Print(string value)
        {
            Random randomColorNumber = new Random();            

            switch (randomColorNumber.Next(0, 4))
            {
                case 1: Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;               
                default:
                    break;
            }

            Console.WriteLine(value);

            Console.ResetColor();            
        }
    }

    class Book : Printer
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Book(string title, string author) : base()
        {
            Title = title;
            Author = author;
        }

        public void PrintBook()
        {
            base.Print(Title);
            base.Print(Author);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Book book = new Book("Code Complete", "Steve McConnell");

            book.PrintBook();
           
        }
    }
}
