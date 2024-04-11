public abstract class SmartDevice
{
    public string Name { get; protected set; }
    public bool IsOn { get; protected set; }
    private DateTime startTime;

    public SmartDevice(string name)
    {
        Name = name;
        IsOn = false;
        startTime = DateTime.MinValue;
    }

    public void TurnOn()
    {
        IsOn = true;
        startTime = DateTime.Now;
        Console.WriteLine($"{Name} turned on.");
    }

    public void TurnOff()
    {
        IsOn = false;
        TimeSpan duration = DateTime.Now - startTime;
        Console.WriteLine($"{Name} turned off. It was on for {duration.TotalMinutes} minutes.");
    }
}