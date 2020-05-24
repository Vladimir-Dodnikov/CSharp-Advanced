using CarEngineAndTires;
using System;

namespace CarConstructors
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(2, 2.4),
                new Tire(3, 2.3),
                new Tire(4, 2.2),
            };
            var engine = new Engine(560, 6300);
            var car = new Car("Lamborgini", "Urus", 2019, 210, 9, engine, tires);

            Console.WriteLine($"{car.Make}\n{car.Model}\n{car.Year}" +
                $"\n{car.Engine.CubicCapacity}\n{car.Engine.HorsePower}\n");
        }
    }
}
