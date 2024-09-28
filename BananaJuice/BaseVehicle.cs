using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// базовый класс для всех видов транспорта
    /// </summary>
    public class BaseVehicle
    {
        /// <summary>
        /// скорость в м/с
        /// </summary>
        protected virtual double Speed { get; set; } = 5;

        /// <summary>
        /// время прохождения дистанции в секундах
        /// </summary>
        protected double _racingTime;

        /// <summary>
        /// имя участника
        /// </summary>
        public string Name;

        /// <summary>
        /// уникальный случайный коэффициент участника
        /// </summary>
        protected double _randomNumber;

        /// <summary>
        /// дистанция указывается в метрах
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="speed"></param>
        public BaseVehicle(double distance, string name) 
        {
            Name = name;

            //у разных участников разные параметры
            Random random = new();
            _randomNumber = random.Next(85, 116);
            _randomNumber /= 100;
        }

        /// <summary>
        /// теоретическое время прохождения дистанции в секундах
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        protected double GetRacingTime(double distance)
        {
            return distance / Speed;
        }

        public double ReturnRacingTime()
        {
            return Math.Round(_racingTime / 60 / 60, 2);
        }
    }
}
