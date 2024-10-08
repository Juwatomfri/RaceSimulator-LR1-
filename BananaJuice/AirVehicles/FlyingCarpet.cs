using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Data.AirVehicles
{
    public class FlyingCarpet : AirVehicle
    {
        public FlyingCarpet(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 4.9 * _randomNumber;
            _acceleration = distance * 0.0002;
            GetAccurateRacingTime(distance);
        }


    }
}
