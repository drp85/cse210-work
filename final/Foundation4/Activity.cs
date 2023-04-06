using System;

class Activity
{
    private string activityType;
    private DateTime date;
    private int length;

    public Activity(string activityType, DateTime date, int length)
    {
        this.activityType = activityType;
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual int GetLength()
    {
        return length;
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{date.ToString("dd MMM yyyy")} {activityType} ({length} min) - ";
        summary += $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
        return summary;
    }
}