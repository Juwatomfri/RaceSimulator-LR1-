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
            this.Speed = 8.3 * this._randomNumber;
            this.TimeLimit = 600 * this._randomNumber;
            this.GetAccurateRacingTime(distance);
        }


    }
}
