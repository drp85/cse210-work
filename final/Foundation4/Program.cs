using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Activity Summary:");

        RunningActivity runningActivity = new RunningActivity(new DateTime(2023, 4, 03), 35, 3);
        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2023, 4, 04), 20, 16);
        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2023, 4, 05), 40, 20);

        Activity[] activities = new Activity[] { runningActivity, cyclingActivity, swimmingActivity };

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
        }
        Console.WriteLine();
    }
}