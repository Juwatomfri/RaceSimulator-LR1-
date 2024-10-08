using Vehicles;

namespace Data.GroundVehicles
{
    public class Domic : GroundVehicle
    {
        public Domic(double distance, string name, string raceType) : base(distance, name, raceType)
        {
            Speed = 16 * _randomNumber;
            TimeLimit = 600 * _randomNumber;
            GetAccurateRacingTime(distance);
        }


    }
}
