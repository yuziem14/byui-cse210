using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int attempts = 0;
        int userGuessNumber;
        string continuePlaying;

        do {
            Console.Write("What is your guess? ");
            userGuessNumber = int.Parse(Console.ReadLine());
            attempts++;

            if(userGuessNumber < magicNumber) {
                Console.WriteLine("Higher");
            } else if(userGuessNumber > magicNumber) {
                Console.WriteLine("Lower");
            } else {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Number of Attempts: {attempts}");

                /** Check if user wants to play again. If yes, it will generate a new magic number, reset attempts and change guess number to not finish the loop */
                Console.WriteLine("Play again (yes)?");
                continuePlaying = Console.ReadLine();

                if(continuePlaying == "yes") {
                    magicNumber = randomGenerator.Next(0, 100);
                    userGuessNumber = -1;
                    attempts = 0;
                }
            }

        } while(magicNumber != userGuessNumber);
    }
}