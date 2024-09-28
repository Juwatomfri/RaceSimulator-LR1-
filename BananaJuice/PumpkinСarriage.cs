using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class PumpkinСarriage : GroundVehicle
    {
        public PumpkinСarriage(double distance, string name) : base(distance, name)
        {
            this.Speed = 8.7 * this._randomNumber;
            this.TimeLimit = 650 * this._randomNumber;

            this.GetAccurateRacingTime(distance);
        }


    }
}
