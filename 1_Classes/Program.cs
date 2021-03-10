using System;

namespace _1_Classes
{
    class Title
    {
        public string Titles { get; set; }

        public Title(string titles)
        {
            Titles = titles;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Title is: {Titles}");
            Console.ResetColor();
        }
    }

    class Author
    {
        public string Authors { get; set; }

        public Author(string authors)
        {
            Authors = authors;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Authors is: {Authors}");
            Console.ResetColor();
        }
    }

    class Content
    {
        public string Contents { get; set; }

        public Content(string contents)
        {
            Contents = contents;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Content is: {Contents}");
            Console.ResetColor();
        }
    }

    class Book
    {
        public Title Title { get; set; }
        public Content Content { get; set; }
        public Author Author { get; set; }


        public Book(string title, string content, string author)
        {
            Title = new Title(title);
            Content = new Content(content);
            Author = new Author(author);
        }

        public void Show()
        {
            Title.Show();
            Content.Show();
            Author.Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Zagolowok", "Opisanniya", "Awtor knigi");

            book.Title.Show();
            book.Content.Show();
            book.Author.Show();

            book.Show();

        }

    }
}
