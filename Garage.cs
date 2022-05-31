namespace Garage
{
    class Garage
    {
        public static void Main(string[] args)
        {
            Zero fxs = new Zero("red");
            Tesla modelS = new Tesla("blue");
            Cessna mx410 = new Cessna("yellow");
            Ram shittyTruck = new Ram("shitty");

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            shittyTruck.Drive();

            mx410.Turn("left");
        }
    }
}