using System;

namespace CarConstructors
{
    public class Car
    {

        private string make;
        private string model;
        private int year;
        private double fuelConsumption;
        private double fuelQuantity;

        public string Make { get => this.make; set => make = value; }
        public string Model { get => this.model; set => model = value; }
        public int Year { get => this.year; set => year = value; }
        public double FuelConsumption { get => this.fuelConsumption; set => fuelConsumption = value; }
        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public void Drive(double distance)
        {
            var consumption = distance * this.FuelConsumption;
            if ((this.FuelQuantity-consumption) >= 0)
            {
                this.FuelQuantity -= consumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}L";
        }
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Audi";
            car.Model = "A4";
            car.Year = 2019;
            car.FuelConsumption = 10;
            car.FuelQuantity = 200;
            car.Drive(1);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
