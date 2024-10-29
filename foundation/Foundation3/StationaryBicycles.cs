using System;

namespace exerciseActivities
{
    public class StationaryBicycles : Activity
    {
        private double _speed;

        public StationaryBicycles(int duration, double speed) : base(duration)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return _speed * Duration / 60;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / GetSpeed();
        }
    }
}