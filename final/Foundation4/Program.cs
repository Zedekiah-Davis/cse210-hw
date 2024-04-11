using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running
        {
            Date = DateTime.Now,
            LengthInMinutes = 30,
            Distance = 3.0
        };
        activities.Add(running);

        StationaryBicycle bicycle = new StationaryBicycle
        {
            Date = DateTime.Now.AddDays(-1),
            LengthInMinutes = 45,
            Speed = 15 // mph
        };
        activities.Add(bicycle);

        LapSwimming swimming = new LapSwimming
        {
            Date = DateTime.Now.AddDays(-2),
            LengthInMinutes = 40,
            Laps = 20
        };
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}