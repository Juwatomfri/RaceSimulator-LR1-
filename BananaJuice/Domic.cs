using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Domic : GroundVehicle
    {
        protected override double Speed { get; set; } = 9;

        protected override double TimeLimit { get; set; } = 500;

        public Domic(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            
            Speed *= _randomNumber; //скорость разных участников одного вида может слегка варьироваться вокруг числа 9
            TimeLimit *= _randomNumber; //время до отдыха у разных участников одного вида может слегка отличаться

            GetAccurateRacingTime(distance);
        }
    }
}
