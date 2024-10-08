using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vehicles;

namespace Data.GroundVehicles
{
    public class SuperBoots : GroundVehicle
    {
        public SuperBoots(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 16 * _randomNumber;
            TimeLimit = 650 * _randomNumber;

            GetAccurateRacingTime(distance);
        }
    }
}
