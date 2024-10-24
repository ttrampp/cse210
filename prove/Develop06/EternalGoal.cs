using System;

namespace eternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {

        }

        public override void RecordEvent()
        {
            Console.WriteLine("Event recorded, but Eternal Goal never completes.");
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"{Name}, {Description}, {Points}, Eternal";
        }

        public override string GetDetailsString()
        {
            int nameColumnWidth = 40;
            string completionMark = IsComplete() ? "[ ]" : "[ ]";
            return string.Format("{0} {1,-" + nameColumnWidth + "} {2}", completionMark, Name, Description);
            //return $"[ ] {Name} -- {Description} (Eternal Goal)";
        }
    }
}