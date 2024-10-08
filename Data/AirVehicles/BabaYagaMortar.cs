using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Data.AirVehicles
{
    public class BabaYagaMortar : AirVehicle
    {
        public BabaYagaMortar(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 5 * _randomNumber;
            _acceleration = distance * 0.00012;
            GetAccurateRacingTime(distance);
        }


    }
}
