using System;

namespace Car
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Audi";
            car.Model = "A4";
            car.Year = 2019;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
