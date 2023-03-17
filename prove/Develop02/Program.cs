using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Daily Journal program!");

        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("\n1. Write new entry\n2. Load file\n3. Save entries to file\n4. Read entries from active file\n5. Quit the program");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Prompt prompt = new Prompt();
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);

                string response = Console.ReadLine();
            
                Console.WriteLine("Journal entry saved.");

            }

            if (choice == "2")
            {
                Console.WriteLine("Please enter the name of the file you would like to load:");
                string filename = Console.ReadLine();


            }

            if (choice == "3")
            {
                Console.WriteLine("Please enter the name of the file you would like to save your entries to:");
                string filename = Console.ReadLine();


            }

            if (choice == "4")
            {                
                Console.WriteLine(Journal.Display()); 
            }

            if (choice == "5")
            {
                repeat = false;
            }
            else
            {
                Console.WriteLine("There was an error with your selection. Please enter the number of the action you would like to perform:");
            }
        }
    }
}
