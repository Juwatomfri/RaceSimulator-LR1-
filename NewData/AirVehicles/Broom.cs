using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Data.AirVehicles
{
    public class Broom : AirVehicle
    {
        public Broom(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 4.8 * _randomNumber;
            _acceleration = distance * 0.00011;
            GetAccurateRacingTime(distance);
        }


    }
}
