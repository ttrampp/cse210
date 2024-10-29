using System;
using System.Data.Common;

namespace exerciseActivities
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _duration;

        protected Activity(int duration)
        {
            _date = DateTime.Now;
            _duration = duration;
        }

        public int Duration
        {
            get { return _duration; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min) - " +
               $"Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
        }
    }
}
