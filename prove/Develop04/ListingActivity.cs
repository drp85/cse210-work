using System;

public class ListingActivity : Activity
{
    private List<string> prompts;
    
    private string GetPrompt()
    {
        prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

        Random random = new Random();

        int total = prompts.Count();
        int num = random.Next(total);
        string question = prompts[num];
        return question;
    }

    public void run()
    {
        Console.WriteLine("How many seconds would you like for the excersize to last?");
        int length = Int16.Parse(Console.ReadLine()) * 1000;

        int itemsCount = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length/1000);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine().Trim();

            itemsCount++;
        } 

        Console.WriteLine("You listed " + itemsCount + " items.");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        end();
    
   
    }
}