using System;

namespace Dotnet_Esential_Task
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Student ctor");
        }
    }
    class Pupil : Student
    {
        static Pupil()
        {
            Console.Write("Bus ctor ");
        }
        public static void Study()
        {
            Console.Write("Study Method ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pupil.Study();
        }
    }

}





