namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses) 
            {
                if(guessCount < guessLimit)
                {
                    Console.Write((guessLimit-guessCount) + " Guess Left Remaining - Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else 
                {
                    outOfGuesses = true;
                    break;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("You win!");
            }
               

            Console.ReadLine();
        }
    }
}
