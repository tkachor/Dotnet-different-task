using System;

namespace _3_Inheritance
{
    class Printer
    {
        public void BaseMethod()
        {
            Console.WriteLine("Base method!");
        }

        public virtual void Print(string value)
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
        public string Author { get; set; }

        public Book(string author) : base()
        {            
            Author = author;
        }

        public override void Print(string value)
        {
            base.Print(value);           
        }

        public void Print(Book book)
        {
            base.Print(book.Author);
        }

        public void Print()
        {
            base.Print(Author);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Book book = new Book("Steve McConnell");

            book.BaseMethod();

            book.Print("Steve McConnell");

            book.Print(book.Author);

            book.Print(book);

            book.Print();

            


           
        }
    }
}
