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
        /// <summary>
        /// Функция отрисовки меню в консоли
        /// </summary>
        /// <param name="items"></param>
        /// <param name="row"></param>
        /// <param name="index"></param>
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

        /// <summary>
        /// Функция выбора типа гонки в меню
        /// </summary>
        /// <param name="row"></param>
        /// <param name="distance"></param>
        public static void UserRaceChoice(int row, double distance)
        {
            int index = 0;
            Console.WriteLine("Выберите тип гонки:");
            row += 2;
            string[] menuItems = new string[] { "Наземная", "Воздушная", "Смешанная" };
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

        /// <summary>
        /// Функция регистрации участника
        /// </summary>
        /// <param name="row"></param>
        /// <param name="raceType"></param>
        /// <param name="distance"></param>
        /// <param name="results"></param>
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
                                if (results.Count != 0)
                                {
                                    ReturnWinner(results);
                                    PrintResults(results);
                                } else
                                {
                                    Console.WriteLine("Вы не зарегистрировали ни одного участника");
                                }
                                return;
                            default:
                                Console.WriteLine("РЕГИСТРАЦИЯ НАЧАЛАСЬ \n");
                                row += 2;
                                RegisterGroundTransport(row, distance, results, raceType);

                                return;
                        }
                }
            }

        }

        /// <summary>
        /// Функция регистрация транспорта
        /// </summary>
        /// <param name="row"></param>
        /// <param name="distance"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public static Dictionary<double, string> RegisterGroundTransport(int row, double distance, Dictionary<double, string> results, string raceType)
        {
            int index = 0;
            Console.WriteLine("Выберите тип транспорта:");
            string[] menuItems = [];
            if (raceType == "наземная")
            {
                menuItems = ["Сапоги-скороходы", "Карета-тыква", "Избушка на курьих ножках", "Кентавр", "Выйти"];
            } else if (raceType == "воздушная")
            {
                menuItems = ["Ступа Бабы Яги", "Метла", "Ковер-самолет", "Летучий корабль", "Выйти"];
            } else if (raceType == "смешанная")
            {
                menuItems = ["Сапоги-скороходы", "Карета-тыква", "Избушка на курьих ножках", "Кентавр", "Ступа Бабы Яги", "Метла", "Ковер-самолет", "Летучий корабль", "Выйти"];
            }
            while (true)
            {
                DrawMenu(items: menuItems, row, index);
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
                            return [];
                        }
                        else
                        {
                            Console.WriteLine("Введите имя участника");
                            string name = Console.ReadLine();
                            row += 2;
                            Console.WriteLine();
                            double abuyz;
                            if (raceType == "наземная")
                            {
                                abuyz = index switch
                                {
                                    0 => new SuperBoots(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    1 => new PumpkinСarriage(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    2 => new Domic(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    3 => new Centaur(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    _ => -1
                                };
                                if (abuyz == -1)
                                {
                                    Console.WriteLine("ВЫБРАН ВЫХОД ИЗ ПРИЛОЖЕНИЯ");
                                    row += 2;
                                    return [];
                                }
                                results[abuyz] = name;
                                StartRegisterTransport(row, "наземная", distance, results);
                                return results;
                            }
                            if (raceType == "воздушная")
                            {
                                abuyz = index switch
                                {
                                    0 => new BabaYagaMortar(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    1 => new Broom(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    2 => new FlyingCarpet(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    3 => new FlyingShip(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    _ => -1
                                };
                                if (abuyz == -1)
                                {
                                    Console.WriteLine("Выбран выход из приложения");
                                    row += 2;
                                    return [];
                                }
                                results[abuyz] = name;
                                StartRegisterTransport(row, "воздушная", distance, results);
                                return results;
                            }
                            if (raceType == "смешанная")
                            {
                                abuyz = index switch
                                {
                                    0 => new SuperBoots(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    1 => new PumpkinСarriage(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    2 => new Domic(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    3 => new Centaur(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    4 => new Broom(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    5 => new BabaYagaMortar(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    6 => new FlyingCarpet(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    7 => new FlyingShip(distance: distance, name: name, raceType).ReturnRacingTime(),
                                    _ => -1
                                };
                                if (abuyz == -1)
                                {
                                    Console.WriteLine("Выбран выход из приложения");
                                    row += 2;
                                    return [];
                                }
                                results[abuyz] = name;
                                StartRegisterTransport(row, "смешанная", distance, results);
                                return results;
                            }
                            return [];

                        }
                }
            }
        }

        /// <summary>
        /// Функция определения победителя
        /// </summary>
        /// <param name="results"></param>
        public static void ReturnWinner(Dictionary<double, string> results)
        {
            double result = results.Keys.ToList().Min();
            int hours = (int)result;
            int minutes = (int)((result - hours) * 60);

            Console.WriteLine($"Победитель: {results[results.Keys.ToList().Min()]} пришёл(ла) первым с результатом {hours} часа(ов) и {minutes} минут(ы).");
            return;
        }

        public static void PrintResults(Dictionary<double, string> results)
        {
            foreach (var item in results)
            {
                int hours = (int)item.Key;
                int minutes = (int)((item.Key - hours) * 60);
                Console.WriteLine($"{ item.Value } проехал трассу за {hours} часа(ов) и {minutes} минут(ы).");
            }
            return;
        }
    }
}
