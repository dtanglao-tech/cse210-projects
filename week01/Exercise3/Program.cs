using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string response = "yes";

        while (response == "yes")
        {
            int number = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            while (guess != number)
            {
                Console.Write("Guess a number between 1 and 100: ");
                string answer = Console.ReadLine();
                
                try
                {
                    guess = int.Parse(answer);
                    guessCount++;
                    
                    if (guess < number)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Too high!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                    guess = -1;
                }
            }
            Console.WriteLine("Congratulations! You guessed the number.");
            Console.WriteLine($"It took you {guessCount} guesses!");
            

            Console.Write("Do you want to play again? (yes/no) ");
            response = Console.ReadLine().ToLower();
        }
    }
}
