using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace RaceSimulator_LR1_.Functions
{
    public class Functions
    {
        public static void DrawMenu(string[] items, int row, int index)
        {
            Console.SetCursorPosition(0, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
            //row += items.Length + 5;
            //return row;
        }

        public static void UserRaceChoice(int row, double distance)
        {
            int index = 0;
            Console.WriteLine("Выберите тип гонки:");
            row += 2;
            string[] menuItems = new string[] { "Наземная", "Воздушная" };
            while (true)
            {
                DrawMenu(menuItems, row, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        row += menuItems.Length + 2;
                        Console.WriteLine($"ВЫБРАНА {menuItems[index].ToUpper()} ГОНКА \n");
                        //row += 2;
                        string raceType = menuItems[index].ToLower();
                        var results = new Dictionary<double, string>();
                        StartRegisterTransport(row, raceType, distance, results);
                        return;
                }
            }
        }

        public static void StartRegisterTransport(int row, string raceType, double distance, Dictionary<double, string> results)
        {
            int index = 0;
            Console.WriteLine("Давайте зарегистрируем участника?");
            row += 2;
            string[] menuItems = new string[] { "Да", "Завершить регистрацию" };
            while (true)
            {
                DrawMenu(menuItems, row, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        row += menuItems.Length + 2;
                        switch (index)
                        {
                            case 1:
                                Console.WriteLine("РЕГИСТРАЦИЯ ЗАВЕРШЕНА");
                                ReturnWinner(results);
                                return;
                            default:
                                Console.WriteLine("РЕГИСТРАЦИЯ НАЧАЛАСЬ \n");
                                row += 2;
                                if (raceType == "наземная")
                                {
                                    RegisterGroundTransport(row, distance, results);

                                }
                                else
                                {
                                    //тут функция регистрации воздушного транспорта
                                    break;
                                }
                                return;
                        }
                        return;
                }
            }

        }

        public static Dictionary<double, string> RegisterGroundTransport(int row, double distance, Dictionary<double, string> results)
        {
            int index = 0;
            Console.WriteLine("Выберите тип транспорта:");
            string[] menuItems = ["Сапоги-скороходы", "Карета-тыква", "Избушка на курьих ножках", "Кентавр", "Выйти"];
            while (true)
            {
                DrawMenu(menuItems, row, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        row += menuItems.Length + 2;
                        if (index == menuItems.Length - 1)
                        {
                            Console.WriteLine("ВЫ ВЫШЛИ ИЗ ПРОГРАММЫ");
                            row += 2;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введите имя участника");
                            string name = Console.ReadLine();
                            row += 2;
                            Console.WriteLine();
                            double abuyz = index switch
                            {
                                0 => new SuperBoots(distance: distance, name: name).ReturnRacingTime(),
                                1 => new PumpkinСarriage(distance: distance, name: name).ReturnRacingTime(),
                                2 => new Domic(distance: distance, name: name).ReturnRacingTime(),
                                3 => new Centaur(distance: distance, name: name).ReturnRacingTime(),
                                _ => -1
                            };
                            if (abuyz == -1)
                            {
                                Console.WriteLine("Выбран выход из приложения");
                                row += 2;
                                return [];
                            }
                            results[abuyz] = name;
                            StartRegisterTransport(row, "наземная", distance, results);
                            return results;
                        }
                }
            }
        }
        public static void ReturnWinner(Dictionary<double, string> results)
        {
            Console.WriteLine($"Победитель: {results[results.Keys.ToList().Min()]} пришёл первым с результатом {results.Keys.ToList().Min()}.");
            return;
        }
    }
}
