using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator_LR1_
{
    public class Vehicle
    {
        public string Name { get; private set; }

        public double Speed { get; private set; }

        public Vehicle(double speed, string name)
        {
            Speed = speed;
            Name = name;
        }
    }
}
