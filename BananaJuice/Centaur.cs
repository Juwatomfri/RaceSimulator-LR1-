using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Centaur : GroundVehicle
    {
        public Centaur(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 15 * _randomNumber;
            TimeLimit = 600 * _randomNumber;
            GetAccurateRacingTime(distance);
        }


    }
}
