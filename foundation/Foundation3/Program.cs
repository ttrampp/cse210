using System;
using System.Collections.Generic;

namespace exerciseActivities
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(30, 3),
                new StationaryBicycles(30, 15.0),
                new SwimmingLapPool(30, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}