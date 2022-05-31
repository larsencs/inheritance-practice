namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public Cessna(string color)
        {
            MainColor = color;
        }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} cessna zoomz by.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"Cessna banks {direction}");
        }
    }
}