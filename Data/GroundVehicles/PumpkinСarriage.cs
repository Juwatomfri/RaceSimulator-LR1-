﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Data.GroundVehicles
{
    public class PumpkinСarriage : GroundVehicle
    {
        public PumpkinСarriage(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 14.5 * _randomNumber;
            TimeLimit = 650 * _randomNumber;

            GetAccurateRacingTime(distance);
        }


    }
}
