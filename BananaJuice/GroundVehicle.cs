using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// базовый класс для наземного транспорта
    /// </summary>
    public class GroundVehicle : BaseVehicle
    {
        /// <summary>
        /// время движения до отдыха в секундах
        /// </summary>
        protected virtual double TimeLimit { get; set; } = 500;

        /// <summary>
        /// время отдыха в секундах
        /// </summary>
        protected double _breakTime;

        /// <summary>
        /// количество требуемых остановок в зависимости от дистанции
        /// </summary>
        protected double _neededBreaks;

        public GroundVehicle(double distance, string name, string raceType) : base(distance, name, raceType) 
        {

            if (raceType.ToLower() != "наземный")
            {
                Console.WriteLine("Наземный транспорт не допускается к воздушным гонкам, учатник не был добавлен");
                return;
            }
        }

        /// <summary>
        /// отдых длится 30 секунд на первой остановке и далее + 30 секунд на каждую остановку
        /// </summary>
        /// <param name="breakNumber"></param>
        protected double GetBreakTime(int breakNumber)
        {
            return(breakNumber * 0.5 * 60);
        }

        /// <summary>
        /// получение точного времени прохождения трассы для конкретного ТС
        /// </summary>
        /// <param name="distance"></param>
        protected void GetAccurateRacingTime(double distance)
        {
            _neededBreaks = Math.Ceiling(GetRacingTime(distance) / TimeLimit);
            for (int i = 0; i < _neededBreaks; i++)
            {
                _breakTime += GetBreakTime(i);
            }
            _racingTime = GetRacingTime(distance) + _breakTime;
        }
            
    }
}