using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activities = new Activity();

        Console.WriteLine("Welcome to the Mindfulness Activity Program.");
        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("\n1. Breathing \n2. Reflecting \n3. Listing \n4. Quit");

            int response = Int16.Parse(Console.ReadLine());
            

            if (response == 4)
                        {
                            repeat = false;
                        }
            else
            {
            string activity = activities.GetActivity(response);
            Console.Clear();
            Console.WriteLine(activity);
            Console.WriteLine("\n \n Press Enter to continue to the activity.");
            Console.ReadLine();
            

            Activity initiate = new Activity();
            initiate.initiate(response);
            }
        }

    }
}