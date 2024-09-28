using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class AirVehicle : BaseVehicle
    {
        /// <summary>
        /// ускорение транспорта
        /// </summary>
        protected virtual double _acceleration { get; set; }

        public AirVehicle(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            if (raceType == "наземный")
            {
                Console.WriteLine("Участник не был зарегистрирован, так как тип гонки не соответствует типу транспорта");
                return;
            }

        }

        /// <summary>
        /// получение точного времени прохождения трассы для конкретного ТС
        /// </summary>
        protected void GetAccurateRacingTime(double distance)
        {
            distance = distance * 1000;
            //финальная скорость
            double finalSpeed = Math.Sqrt(2 * _acceleration * distance) * _randomNumber;
            //время заезда
            _racingTime = finalSpeed/_acceleration;
        }



    }
}
