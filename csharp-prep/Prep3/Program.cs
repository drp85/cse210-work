using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1,100);
        Console.WriteLine("Generated magic number");
        bool success = false;
        while (success == false)
        {
            Console.WriteLine("Guess an integer between 1 and 100.");
            string stringguess = Console.ReadLine();
            int guess = Int16.Parse(stringguess);

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                success = true;
            }
            else if (guess > number)
            {
                Console.WriteLine("That's too high!");
            }
            else if (number > guess)
            {
                Console.WriteLine("That's too low!");
            }
            else Console.WriteLine("Error!");
        }
    }
}