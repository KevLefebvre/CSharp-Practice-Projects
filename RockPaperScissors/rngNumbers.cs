using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RngNumbers
    {
        private readonly Random _random = new Random();

        /* Old Method:
        public int GetRngNum(int min = 1, int maxExclusive = 4)
        {           
            return _random.Next(min, maxExclusive);   
        }
        */

        /*
            Updated method below with Lambda arrow gets rid of the need of the block with the return
            => is the Lambda arrow. It tells C# this method has a single expression, and the return value is the result of that expression.
        */
        public int GetRngNum(int min = 1, int maxExclusive = 4)
            => _random.Next(min, maxExclusive);


        public string GetRngChoice()
        {
            // this could be: int roll = GetRngNum(); because of what's defaulted by the method above. But any # here would override the default values.
            int roll = GetRngNum(1, 4);
            return roll switch
            {
                1 => "rock",
                2 => "paper",
                _ => "scissors" // the "_" means anything else -> return . Kinda act like a discard/wildcard. It matches any value not already matched above then return this.
            };

            /*
             * Beginner way of if statement to return value. Updated/cleaner way is above using switch.
            string result = "";

            if (roll == 1)
            {
                result = "rock";
 
            }
            else if (roll == 2)
            {
                result = "paper";
                
            }
            else if (roll == 3)
            {
                result = "scissors";
                
            }
            return result;
            */

        }
        // Helper method to ask a yes/no question and return true/false
        public bool PromptYesNo(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine()?.Trim().ToLower();

                switch (input)
                {
                    case "y":
                        return true;

                    case "n":
                        Console.WriteLine("Thanks for Playing!");
                        return false;

                    default:
                        Console.WriteLine("Please type 'y' or 'n'.");
                        break;
                }
            }
        }


    }


}
