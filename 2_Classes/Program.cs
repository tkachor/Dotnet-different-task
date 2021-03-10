using System;

namespace _2_Classes
{
    /*Создать класс Converter.
    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
    и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
    Converter(double usd, double eur, double rub).
    Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
    также программа должна производить конвертацию из указанных валют в гривну. */

    class Converter
    {
        public double UsdRate { get; set; }
        public double EurRate { get; set; }
        public double RubRate { get; set; }
        public double UahRate { get; set; }

        public Converter() { }

        public Converter(double usd, double eur, double rub)
        {
            UsdRate = usd;
            EurRate = eur;
            RubRate = rub;
        }

        public double UahToUsd(double uah)
        {
            return uah / UsdRate;
        }

        public double UahToEur(double uah)
        {
            return uah / EurRate;
        }

        public double UahToRub(double uah)
        {
            return uah / RubRate;
        }

        public double UsdToUah(double usd)
        {
            return usd * UsdRate;
        }

        public double EurToUah(double eur)
        {
            return eur * EurRate;
        }

        public double RubToUah(double rub)
        {
            return rub * RubRate;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Converter conv = new Converter(28.05, 33.12, 0.36);
            Console.WriteLine("Exchange rate UAH for today is: \n USD : 28.05\n EUR : 33.12\n RUB : 0.36 ");
            Console.WriteLine("\n\nPlease select the currency you want to exchange: \n1 - UAH \n 2 - USD\n 3 - EUR\n 4 - RUB");
            int selectCurrency = int.Parse(Console.ReadLine());

            if (selectCurrency == 1)
            {
                Console.WriteLine("Please choose which currency you want to exchange: \n1 - USD\n 2 - EUR\n 3 - RUB");
                int witchCurrency = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the amount in UAH:");
                double amountUah = double.Parse(Console.ReadLine());
                switch (witchCurrency)
                {
                    case 1:
                        Console.WriteLine($"You will receive: {conv.UahToUsd(amountUah)}");
                        break;
                    case 2:
                        Console.WriteLine($"You will receive: {conv.UahToEur(amountUah)}");
                        break;
                    case 3:
                        Console.WriteLine($"You will receive: {conv.UahToRub(amountUah)}");
                        break;

                    default:
                        Console.WriteLine("You entered a non-existent value");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please enter the amount:");
                double amount = double.Parse(Console.ReadLine());
                switch (selectCurrency)
                {
                    case 2:
                        Console.WriteLine($"You will receive: {conv.UsdToUah(amount)}");
                        break;
                    case 3:
                        Console.WriteLine($"You will receive: {conv.EurToUah(amount)}");
                        break;
                    case 4:
                        Console.WriteLine($"You will receive: {conv.RubToUah(amount)}");
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
