using System;

class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int length, int laps) : base("Swimming", date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return Double.Round((laps * 50 / 1000 * 0.62),2); 
    }

    public override double GetSpeed()
    {
        return Double.Round((GetDistance() / GetLength() * 60),2); 
    }

    public override double GetPace()
    {
        return Double.Round((GetLength() / GetDistance()),2); 
    }
}