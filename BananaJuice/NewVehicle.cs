using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaJuice
{
    public class NewVehicle
    {
        public string Name { get; private set; }

        public double Speed { get; private set; }

        public NewVehicle(double speed, string name)
        {
            Speed = speed;
            Name = name;
        }
    }
}
