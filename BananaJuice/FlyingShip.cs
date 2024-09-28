using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class FlyingShip : AirVehicle
    {
        public FlyingShip(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 5 * _randomNumber;
            _acceleration = distance * 0.00013;
            GetAccurateRacingTime(distance);
        }


    }
}
