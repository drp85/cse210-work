using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Daily Journal program!");

        bool repeat = true;
        Journal journal = new Journal("journal.txt");

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

                Entry entry = new Entry(randomPrompt, response);
                journal.AddEntry(entry);

                Console.WriteLine("Journal entry saved.");
            }

            else if (choice == "2")
            {
                Console.WriteLine("Please enter the name of the file you would like to load:");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("<>");
                    
                }
                foreach (string parts in lines)
                {
                    if (!string.IsNullOrEmpty(parts))
                    {
                        string[] portions = parts.Split("|||");
                        if (parts.Length == 2)
                        {
                            string prompt = portions[0];
                            string response = portions[1];
                            Entry entry = new Entry(prompt, response);
                            journal.entries.Add(entry);
                        }
                    }
                }

            }

            else if (choice == "3")
            {
                Console.WriteLine("Please enter the name of the file you would like to save your entries to:");
                string filename = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (Entry entry in journal.entries)
                    {
                        sw.WriteLine($"{entry.GetDate()}|||{entry.GetPrompt()}|||{entry.GetResponse()}<>");  
                    }
                }
            }

            else if (choice == "4")
            {
                journal.Display(); 
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }

            else if (choice == "5")
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
