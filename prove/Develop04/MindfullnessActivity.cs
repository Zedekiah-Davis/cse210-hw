public abstract class MindfulnessActivity
{
    protected int duration;

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    public abstract void Start();

    protected void ShowStartingMessage(string description)
    {
        Console.WriteLine($"Starting {GetType().Name} Activity:");
        Console.WriteLine(description);
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void ShowEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {GetType().Name} Activity.");
        Console.WriteLine($"Activity duration: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void ShowCountdown()
    {
        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}