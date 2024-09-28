using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vehicles
{
    public class SuperBoots : GroundVehicle
    {
        public SuperBoots(double distance, string name) : base(distance, name)
        {
            Speed = 9.5 * _randomNumber;
            TimeLimit = 650 * _randomNumber;

            GetAccurateRacingTime(distance);
        }


    }
}
