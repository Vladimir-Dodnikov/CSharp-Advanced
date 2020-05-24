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
        public Car()
        {
            this.Make = "VW";
            this.Model = "GOLF";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelConsumption, double fuelQuantity)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }
        public void Drive(double distance)
        {
            var consumption = distance * this.FuelConsumption / 100;
            if (consumption < this.FuelQuantity)
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
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            var fuelQuantity = double.Parse(Console.ReadLine());
            var fuelConsumption = double.Parse(Console.ReadLine());
            _ = new Car();
            _ = new Car(make, model, year);
            _ = new Car(make, model, year, fuelQuantity, fuelConsumption);

        }
    }
}
