/*
  This is a Rock Paper Scissor Game.
  Practiced do/while loops, classes, methods, if statements, comparison, rng implementation, user input, switch, validations,interpolation, concatenation
  Updated code for better comprehension/practice overtime
 */
using System.Runtime.Intrinsics.Arm;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            string rollResult;
            RngNumbers roll = new RngNumbers();
            RngNumbers yesOrNo = new RngNumbers();
            bool continueGame = true;
            

            do
            {
                // Player Choice
                Console.Write("Rock, Paper or Scissors?: ");
                playerInput = Console.ReadLine()?.Trim().ToLower();

                //Player Choice validation
                if (playerInput != "rock" && playerInput != "paper" && playerInput != "scissors")
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
                }

                //Computer Roll
                rollResult = roll.GetRngChoice();
                Console.WriteLine($"The computer chose: {rollResult}");
                /*  
                    called interpolation, $ tells c# its interpolation, can embed calculation, formatting, methods calls.
                    Basic way to print on Console. Example above is better esp with more variables.
                    Console.WriteLine("The computer chose: " + rollResult); This is called concatenation + + + 
                */

                //Result
                if (rollResult == playerInput)
                {
                    Console.WriteLine("It's a Draw!");
                }
                else if ((rollResult == "rock" && playerInput == "paper") ||
                         (rollResult == "paper" && playerInput == "scissors") ||
                         (rollResult == "scissors" && playerInput == "rock"))

                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }

                //Replay
                //Decided to make a method for a prompt of yes/no, reusable for other projects.
                continueGame = yesOrNo.PromptYesNo("Play again? y/n ");

                /* Old Method:
                bool playAgain = true;
                while (playAgain)
                {
                    Console.WriteLine("Play again?: Y/N");
                    playerInput = Console.ReadLine()?.Trim().ToLower();
                    if (playerInput != "y" && playerInput != "n")
                    {
                        Console.WriteLine("Wrong entry!");
                        continue;
                    }
                    else if (playerInput == "n")
                    {
                        //Ending Message
                        Console.WriteLine("Thanks for playing!");
                        continueGame = false;
                        playAgain = false;

                    }
                    else 
                    {
                        playAgain = false;
                    }
                }
                */

            }
            while (continueGame);












        }
    }
}
