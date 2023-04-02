using System;

public class Activity
{
    private Dictionary<int, string> activities;

    public Activity()
    {
        activities = new Dictionary<int, string>();
        activities[1] = ("The Breathing activity is designed to help the user pace their breathing with a deep breathing excersize.\nThe user might find more peace and less stress through the excersize.");
        activities[2] = ("The Reflection activity is designed to help the user think deeply by having them conside and experience where they were successful or demonstrated strength.\nThe user might discover more breadth than they previously realized.");    
        activities[3] = ("The Listing activity is designed to help the user thing broadly by helping them list as many things they can in a certain area of strength or positivity.\n The user might discover more breadth than they previously realized.");

    }

    public string GetActivity(int activity)
    {
        return this.activities[activity];
    }

    public void initiate(int activity)
    {
        switch (activity)
        {
            case 1:
            BreathingActivity breathe = new BreathingActivity();
            breathe.run();
            break;

            case 2:
            ReflectingActivity reflect = new ReflectingActivity();
            reflect.run();
            break;

            case 3:
            ListingActivity list = new ListingActivity();
            list.run();
            break;

            case 4:
            bool repeat = false;
            break;
            
            default:
            Console.Clear();
            Console.WriteLine("Error: Invalid Selection");
            break;
        }
    }
    //pause while showing a spinner
    public void pause(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time / 1000);
        
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("  o  \no   o\n  o  ");
            Thread.Sleep(250);
            Console.Clear();
            Console.WriteLine("o   o\n\no   o");
            Thread.Sleep(250);
            Console.Clear();
        }
        
    }
    //pause while showing a countdown timer

    public void end()
    {
        Console.Clear();
        Console.WriteLine("Good Job!");
        int time = 1000;
        this.pause(time);
    }
}