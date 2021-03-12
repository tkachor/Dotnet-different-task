using System;

namespace _4_Inheritance
{

    /* Создать класс, представляющий учебный класс ClassRoom.
    Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
    Write(), void Relax().
    Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
    Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
    Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
    Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
    Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
    писать, отдыхать.
    */

    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Good Study");
        }

        public virtual void Read()
        {
            Console.WriteLine("Good Read");
        }

        public virtual void Write()
        {
            Console.WriteLine("Good Write");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Good Relax");
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent Study");
        }

        public override void Read()
        {
            Console.WriteLine("Excelent Read");
        }

        public override void Write()
        {
            Console.WriteLine("Excelent Write");
        }

        public override void Relax()
        {
            base.Relax();
        }

    }
        
        
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
        }

        public override void Read()
        {
            base.Read();
        }

        public override void Write()
        {
            base.Write();
        }

        public override void Relax()
        {
            Console.WriteLine("Excelent Relax");
        }

    }
        
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad Study");
        }

        public override void Read()
        {
            Console.WriteLine("Bad Read");
        }

        public override void Write()
        {
            Console.WriteLine("Bad Write");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad Relax");
        }


    }

    class ClassRoom 
    {
        public Pupil[] pupils = new Pupil[4];

        public ClassRoom() { }

        public ClassRoom(Pupil pupil1)
        {
            pupils[0] = pupil1;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil3;
        }

        public void InfoClass()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"\nPupil №{i+1}:\n");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine("---------------");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {           

            Pupil pupilExelentOne = new ExcelentPupil();
            Pupil pupilExelentTwo = new Pupil();
            Pupil pupilGood = new GoodPupil();
            Pupil pupilBad = new BadPupil();

            ClassRoom classRoom1 = new ClassRoom(pupilExelentOne, pupilExelentTwo, pupilGood, pupilBad);

            classRoom1.InfoClass();
        }
    }
}
