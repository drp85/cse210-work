using System;

public class BreathingActivity : Activity
{
    public void run()
    {
        Console.Clear();
        Console.WriteLine("Starting the Breathing activity.");
        Activity pause = new Activity();
        Thread.Sleep(2000);
        int time = 1000;
        pause.pause(time);

        Console.WriteLine("How many seconds would you like for the excersize to last?");
        int length = Int16.Parse(Console.ReadLine()) * 1000;

        Console.WriteLine("Follow the prompts; focus on your breathing.");
        Thread.Sleep(1500);
        time = 1500;
        pause.pause(time);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length/1000);
        
        while (DateTime.Now < endTime)
        {
        Console.Clear();
        Console.WriteLine("Breathe In");
        Thread.Sleep(2000);
        time = 2000;
        pause.pause(time);
        Console.WriteLine("Hold");
        Thread.Sleep(2000);
        time = 3000;
        pause.pause(time);
        Console.WriteLine("Breathe out");
        Thread.Sleep(2000);
        time = 5000;
        pause.pause(time);
        }
        
        end();
    }
}