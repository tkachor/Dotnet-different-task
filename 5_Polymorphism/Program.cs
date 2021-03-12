using System;

namespace _5_Inheritance
{
    /*Создать класс Vehicle.
    В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
    выпуска).
    Создайте 3 производных класса Plane, Саг и Ship.
    Для класса Plane должна быть определена высота и количество пассажиров.
    Для класса Ship — количество пассажиров и порт приписки.
    Написать программу, которая выводит на экран информацию о каждом средстве передвижения*/

    class Vehicle
    {
        public int Price { get; set; }
        public int Speed { get; set; }
        public int GraduationYear { get; set; }

        public Vehicle(int price, int speed, int graduationYear)
        {
            Price = price;
            Speed = speed;
            GraduationYear = graduationYear;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"GraduationYear: {GraduationYear}");
        }
    }

    class Car : Vehicle
    {
        public string Color { get; set; }
        public Car(string color, int price, int speed, int graduationYear) : base(price, speed, graduationYear)
        {
            Color = color;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Plane : Vehicle
    {
        public int MaxHeight { get; set; }
        public int NumberOfPassengers { get; set; }

        public Plane(int maxHeight, int numberOfPassengers, int price, int speed, int graduationYear) : base(price, speed, graduationYear)
        {
            MaxHeight = maxHeight;
            NumberOfPassengers = numberOfPassengers;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Color: {MaxHeight}");
            Console.WriteLine($"Color: {NumberOfPassengers}");
        }
    }

    class Ship : Vehicle
    {
        public string Port { get; set; }
        public int NumberOfPassengers { get; set; }

        public Ship(string port, int numberOfPassengers, int price, int speed, int graduationYear) : base(price, speed, graduationYear)
        {
            Port = port;
            NumberOfPassengers = numberOfPassengers;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Port: {Port}");
            Console.WriteLine($"NumberOfPassengers: {NumberOfPassengers}");
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Car car = new Car("Red", 45000, 320, 2020);
            Plane plane = new Plane(8000, 150, 75000000, 950, 2018);
            Ship ship = new Ship("Amsterdam", 3000, 450000000, 75, 2016);

            car.PrintInfo();
            plane.PrintInfo();
            ship.PrintInfo();







        }
    }
}
