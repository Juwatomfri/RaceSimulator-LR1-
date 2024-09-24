using BananaJuice;

namespace RaceSimulator_LR1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle flyingShip = new(speed: 5, name: "baba");
            NewVehicle flyingShip = new(speed: 5, name: "baba");

            Console.WriteLine(flyingShip);
        }
    }
}
