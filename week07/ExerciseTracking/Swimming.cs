public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceInKm = (_laps * 50) / 1000.0;
        double distanceInMiles = distanceInKm * 0.62;
        return Math.Round(distanceInMiles, 2); 
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetMinutes()) * 60;
        return Math.Round(speed, 2); 
    }

    public override double GetPace()
    {
        double pace = GetMinutes() / GetDistance();
        return Math.Round(pace, 2); 
    }
}
