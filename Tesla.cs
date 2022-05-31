namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public Tesla(string color)
        {
            MainColor = color;
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }
                public override void Drive()
        {
            Console.WriteLine($"The {MainColor} tesla brrrs by.");
        }
    }
}