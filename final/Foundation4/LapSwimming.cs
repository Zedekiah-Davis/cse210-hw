public class LapSwimming : Activity
{
    public int Laps { get; set; }
    public const double LapLengthInMeters = 50;

    public override double GetDistance()
    {
        return Laps * LapLengthInMeters / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthInMinutes * 60 * 0.62; // Convert km to miles
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}