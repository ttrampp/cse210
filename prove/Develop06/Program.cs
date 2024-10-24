//Core requirements met
//Additional Exceeding requirements added throughout the code
//Exceeding requirements include:
//--BONUS POINTS
//--COLOR FEATURES FOR USER FRIENDLY EASE, 
//==ACHIEVEMENT TRACKING AND REWARDING, INCLUDING AN ON GOING REWARD SYSTEM FOR EVERY 500 POINTS EARNED.


using System;

namespace eternalQuest
{

    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();

            goalManager.Start();
        }
    }
}