using System;

namespace exerciseActivities
{
    public class SwimmingLapPool : Activity
    {
        private int _laps;
        private const double LapDistanceMiles = 50.0 / 1000 * 0.62;

        public SwimmingLapPool(int duration, int laps) : base(duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * LapDistanceMiles;
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
