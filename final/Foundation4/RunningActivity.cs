using System;

class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int length, double distance) : base("Running", date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return Double.Round((distance),2);
    }

    public override double GetSpeed()
    {
        return Double.Round((distance / GetLength() * 60),2);
    }

    public override double GetPace()
    {
        return Double.Round((GetLength() / distance),2);
    }
}