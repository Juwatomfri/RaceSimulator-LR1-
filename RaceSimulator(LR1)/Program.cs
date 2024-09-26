using Vehicles;

namespace RaceSimulator_LR1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дистанцию заезда в километрах: ");

            double distance = Convert.ToDouble(Console.ReadLine()) * 1000;

            Console.WriteLine("Выберите вид заезда: воздушный/наземный");

            string raceType = Console.ReadLine();

            Centaur Yakov1 = new(distance: distance, name: "Кентаврик", raceType: raceType);
            SuperBoots Yakov2 = new(distance: distance, name: "Ботиночки", raceType: raceType);
            Domic Yakov3 = new(distance: distance, name: "Избушка", raceType: raceType);
            PumpkinСarriage Yakov4 = new(distance: distance, name: "Тыковка", raceType: raceType);

            Console.WriteLine(Yakov1.PrintRacingTime() + " " + Yakov1.Name);
            Console.WriteLine(Yakov2.PrintRacingTime() + " " + Yakov2.Name);
            Console.WriteLine(Yakov3.PrintRacingTime() + " " + Yakov3.Name);
            Console.WriteLine(Yakov4.PrintRacingTime() + " " + Yakov4.Name);
            
        }
    }
}
