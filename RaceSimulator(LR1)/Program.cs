using System;
using System.Reflection;
using System.Security.AccessControl;
using System.Xml.Linq;
using Vehicles;
using static RaceSimulator_LR1_.Functions.Functions;

namespace RaceSimulator_LR1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = new string[] { "Запустить гонку", "Выход" };

            Console.WriteLine("Давайте запустим гонку? \n");

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
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
                                Console.WriteLine("Выбран выход из приложения");
                                row += 2;
                                return;
                            default:
                                Console.WriteLine($"ВЫБРАН ПУНКТ \"{menuItems[index].ToUpper()}\"\n");
                                row += 2;
                                Console.WriteLine("Введите дистанцию гонки в километрах");
                                double distance = Convert.ToDouble(Console.ReadLine());
                                row += 2;
                                Console.WriteLine();
                                UserRaceChoice(row, distance);
                                return;
                        }
                }
            }
        }
        
    }
}
