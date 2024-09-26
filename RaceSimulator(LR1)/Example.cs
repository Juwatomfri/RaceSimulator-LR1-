using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulator_LR1_
{
    public class Example
    {
        public string Name { get; private set; }

        public double Speed { get; private set; }

        public double TimeLimit { get; private set; }
        public double BreakTime { get; private set; }


        public Example(double speed, string name)
        {
            Speed = speed;
            Name = name;
        }
    }
}
