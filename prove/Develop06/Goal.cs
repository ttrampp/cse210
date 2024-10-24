using System;

namespace eternalQuest
{
    public abstract class Goal
    {
        private string _name;
        private string _description;
        private int _points;

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public int Points
        {
            get { return _points; }
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStringRepresentation();

        public virtual string GetDetailsString()
        {
            return $"[ ] {_name} -- {_description}";
        }


    }
}