using System;

namespace _8_Arrays
{

    /*Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
    среднее арифметическое всех элементов, вывести все нечетные значения.
    */   

    class Program
    {
        public static int[] CreateIntegerArrays(int numberOfElement)
        {
            int[] rezult = new int[numberOfElement];
            Random random = new Random();

            for (int i = 0; i < numberOfElement; i++)
            {
                rezult[i] = random.Next(0, 100);
            }

            return rezult;
        }


        static void Main(string[] args)
        {
            var array = CreateIntegerArrays(20);
            int SumOfAllArrayElment = 0;
            int MaxElementOfArray = array[0];
            int MinElementOfArray = array[0];
            

            foreach (var item in array)
            {
                Console.Write($"[{item}] ");
                SumOfAllArrayElment += item;

                if (MaxElementOfArray < item)                
                    MaxElementOfArray = item;

                if (MinElementOfArray > item)
                    MinElementOfArray = item;
            }

            int AverageOfArray = SumOfAllArrayElment / array.Length;

            Console.WriteLine("\nSum Of All Array Elment: " + SumOfAllArrayElment);
            Console.WriteLine("Max Elemen of Array: " + MaxElementOfArray);
            Console.WriteLine("Min Elemen of Array: " + MinElementOfArray);
            Console.WriteLine("Average of Array: " + AverageOfArray);


        }
    }
}
