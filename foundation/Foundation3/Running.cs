using System;

namespace exerciseActivities
{
    public class Running : Activity
    {
        private double _distance;

        public Running(int duration, double distance) : base(duration)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return GetDistance() / Duration * 60;
        }

        public override double GetPace()
        {
            return Duration / GetDistance();
        }

    }
}