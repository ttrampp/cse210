using System;
using System.ComponentModel.DataAnnotations;

namespace eternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _timesCompleted;
        private int _targetCompletion;
        private int _bonusPoints;

        public ChecklistGoal(string name, string description, int points, int targetCompletion, int bonusPoints) : base(name, description, points)
        {
            _timesCompleted = 0;
            _targetCompletion = targetCompletion;
            _bonusPoints = bonusPoints;
        }

        public void SetTimesCompleted(int timesCompleted)
        {
            _timesCompleted = timesCompleted;
        }

        public override void RecordEvent()
        {
            _timesCompleted++;

            if (_timesCompleted >= _targetCompletion)
            {
                Console.WriteLine($"Goal completed! Awarded {Points + _bonusPoints} points.");
            }
            else
            {
                Console.WriteLine($"Event recorded. Awarded {Points} points.");
            }
        }

        public override bool IsComplete()
        {
            return _timesCompleted >= _targetCompletion;
        }

        public override string GetDetailsString()
        {
            int nameColumnWidth = 40;
            string completionMark = IsComplete() ? "[X]" : "[ ]";
            
            //return $"{completionMark} {Name.PadRight(nameColumnWidth)} - {Description} ({_timesCompleted}/{_targetCompletion}) times";
            return string.Format("{0} {1,-" + nameColumnWidth + "} {2} ({3}/{4}) times.", completionMark, Name, Description, _timesCompleted, _targetCompletion);
        }

        public override string GetStringRepresentation()
        {
            return $"{Name}, {Description}, {Points}, {_timesCompleted}/{_targetCompletion}, {_bonusPoints}";
        }
    }
}