namespace CarEngineAndTires
{
    public class Tire
    {
        private int year;
        private double preasure;
        public Tire(int year, double preasure)
        {
            this.Year = year;
            this.Preasure = preasure;
        }
        public int Year { get; set; }
        public double Preasure { get; set; }
    }
}
