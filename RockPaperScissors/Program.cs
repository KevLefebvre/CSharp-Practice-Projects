/*
  This is a Rock Paper Scissor Game.
  Practiced do/while loops, classes, methods, if statements, comparison, rng implementation, user input.
 */
using System.Runtime.Intrinsics.Arm;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerChoice;
            string rollResult;
            string playAgain;
            rngNumbers roll = new rngNumbers();
            bool continueGame = true;

            do
            {

                Console.Write("Rock, Paper or Scissors?: ");
                playerChoice = Console.ReadLine()?.Trim().ToLower();

                if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
                }

                rollResult = roll.getRngChoice();
                if (rollResult == playerChoice)
                {
                    Console.WriteLine("The computer chose: " + rollResult);
                    Console.WriteLine("It's a Draw!");
                }
                else if ((rollResult == "rock" && playerChoice == "paper") ||
                         (rollResult == "paper" && playerChoice == "scissors") ||
                         (rollResult == "scissors" && playerChoice == "rock"))

                {
                    Console.WriteLine("The computer chose: " + rollResult);
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("The computer chose: " + rollResult);
                    Console.WriteLine("You Lose!");
                }

                Console.WriteLine("Play again?: Y/N");
                playAgain = Console.ReadLine()?.Trim().ToLower();
                if (playAgain == "n")
                {
                    continueGame = false;
                }

            }
            while (continueGame);












        }
    }
}
