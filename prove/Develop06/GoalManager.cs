using System;
using System.IO.Compression;
using System.IO;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace eternalQuest
{
    public class GoalManager
    {
        private List<Goal> goals = new List<Goal>();
        private int userPointsTotal = 0;
        private int lastMilestone = 0;

        private const string filePath = "GoalList.txt";



        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("**********************************************************");
                Console.WriteLine("**********************************************************");
                Console.WriteLine("***************WELCOME TO THE ETERNAL QUEST***************");
                Console.WriteLine("*******************GOAL SETTING PROGRAM*******************");
                Console.WriteLine("**********************************************************");
                Console.WriteLine("**********************************************************");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Select the number of the choices below: ");
                Console.WriteLine();
                Console.WriteLine("1. Display Points");
                Console.WriteLine("2. List Goal Details");
                Console.WriteLine("3. Create a New Goal");
                Console.WriteLine("4. Record Event");
                Console.WriteLine("5. Save Goals");
                Console.WriteLine("6. Load Goals (Must load goals before inital listing)");
                Console.WriteLine("7. Quit");
                Console.WriteLine("**********************************************************");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Display Total Points Earned.");
                        DisplayUserInfo();
                        break;

                    case "2":
                        Console.Clear();
                        ListGoalDetails();
                        break;

                    case "3":
                        CreateGoal();
                        break;

                    case "4":
                        RecordEvent();
                        break;

                    case "5":
                        SaveGoals(filePath);
                        break;

                    case "6":
                        LoadGoals();
                        break;

                    case "7":
                        Console.WriteLine("Come back again soon.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }


        public void DisplayUserInfo()
        {
            Console.WriteLine($"Points Total: {userPointsTotal}");
        }

        public void ListGoalNames()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals available.");
                return;
            }

            Console.WriteLine("Goal Names: ");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }
        }

        public void ListGoalDetails()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals available.");
                return;
            }

            Console.WriteLine("Goal Details: ");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Select the type of goal to create:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("**********************************************************");

            string choice = Console.ReadLine();
            Console.Write("Enter the goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the point value for this goal: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter the target completion number: ");
                    int targetCompletion = int.Parse(Console.ReadLine());
                    Console.Write("Enter the bonus points for completion: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, description, points, targetCompletion, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void RecordEvent()
        {
            ListGoalNames();
            Console.WriteLine("Which goal did you complete? Enter the number: ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                goals[goalIndex].RecordEvent();
                userPointsTotal += goals[goalIndex].Points;
                Console.WriteLine($"Event recorded. You have earned {goals[goalIndex].Points} points for this goal.");
                CheckForAchievement();
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private void CheckForAchievement()
        {
            if (userPointsTotal >= lastMilestone + 500)
            {
                lastMilestone = userPointsTotal / 500 * 500;
                DisplayAchievement();
            }
        }

        private void DisplayAchievement()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine("      Congratulations!");
            Console.WriteLine($"You've earned {lastMilestone} points!");
            Console.WriteLine("     You deserve a ribbon!");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine("Press any key to see your new ribbon!");
            Console.ReadKey();
            Console.Clear();
            DisplayRibbon();
        }
        private void DisplayRibbon()
        {
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("          *********");
            Console.WriteLine("       ***************");
            Console.WriteLine("     ***             ***");
            Console.WriteLine("    ***   GOOD JOB    ***");
            Console.WriteLine("   ***    500 POINT    ***");
            Console.WriteLine("    ***    RIBBON!    ***");
            Console.WriteLine("     ***             ***");
            Console.WriteLine("       **************");
            Console.WriteLine("          *********");
            Console.WriteLine("            *****");
            Console.WriteLine("             ***");
            Console.WriteLine("            *****");
            Console.WriteLine("          ***   ***");
            Console.WriteLine("         ***     ***");
            Console.WriteLine("        ***       ***");
            Console.WriteLine("       ***         ***");
            Console.WriteLine("      ***           ***");
            Console.WriteLine("     ***             ***");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void SaveGoals(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(userPointsTotal);
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals and points saved.");
        }

        public void LoadGoals()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Sorry, no goals found.");
                return;
            }

            goals.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                if (!int.TryParse(reader.ReadLine(), out userPointsTotal))
                {
                    userPointsTotal = 0;
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length < 4)
                    {
                        Console.WriteLine("Invalid format, skipping.");
                        continue;
                    }

                    string name = parts[0].Trim();
                    string description = parts[1].Trim();

                    int points;
                    if (!int.TryParse(parts[2].Trim(), out points))
                    {
                        Console.WriteLine($"Error parsing points for goal '{name}'. Skipping this goal.");
                        continue;
                    }

                    if (parts[3].Trim() == "Eternal")
                    {
                        goals.Add(new EternalGoal(name, description, points));
                    }

                    else if (parts[3].Contains("/"))
                    {
                        string[] progress = parts[3].Split('/');
                        int _timesCompleted = int.Parse(progress[0]);
                        int targetCompletion = int.Parse(progress[1]);
                        int bonusPoints = int.Parse(parts[4].Trim());

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCompletion, bonusPoints);

                        checklistGoal.SetTimesCompleted(_timesCompleted);
                        goals.Add(checklistGoal);
                    }
                    else
                    {
                        Console.WriteLine("Unexpected number of parts, skipping.");
                    }
                }
            }
            Console.WriteLine("Goals and points loaded.");
        }
    }
}