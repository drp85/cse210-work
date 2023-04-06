using System;

class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int length, double speed) : base("Cycling", date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return Double.Round((speed),2);
    }

    public override double GetDistance()
    {
        return Double.Round((speed * GetLength() / 60),2);
    }

    public override double GetPace()
    {
        return Double.Round((60 / speed),2);
    }
}