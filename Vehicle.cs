namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Vehicle turns {direction}");
        }
        public virtual void Stops()
        {
            Console.WriteLine("Vehicle stops.");
        }
    }
}