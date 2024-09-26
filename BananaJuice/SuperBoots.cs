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
        public SuperBoots(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            this.Speed = 9.5 * this._randomNumber;
            this.TimeLimit = 650 * this._randomNumber;

            this.GetAccurateRacingTime(distance);
        }


    }
}
