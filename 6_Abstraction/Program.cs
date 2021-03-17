using System;

namespace _6_Abstraction
{

    /*Создайте класс AbstractHandler.
    В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
    Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
    AbstractHandler.
    Написать программу, которая будет выполнять определение документа и для каждого формата
    должны быть методы открытия, создания, редактирования, сохранения определенного
    формата документа. */

    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();        
    }

    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");
        }

        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }     
    }

    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler xmlHandler = new XMLHandler();            

            xmlHandler.Create();
            xmlHandler.Open();
            xmlHandler.Chenge();          
            xmlHandler.Save();
            
            AbstractHandler txtHandler = new TXTHandler();            

            txtHandler.Create();
            txtHandler.Open();
            txtHandler.Chenge();
            txtHandler.Save();

            AbstractHandler docHandler = new DOCHandler();

            docHandler.Create();
            docHandler.Open();
            docHandler.Chenge();
            docHandler.Save();




        }
    }
}
