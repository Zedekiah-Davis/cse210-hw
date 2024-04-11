public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        ShowStartingMessage("This activity will help you relax by guiding you through deep breathing exercises. Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Pause for 2 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); // Pause for 2 seconds
        }

        ShowEndingMessage();
    }
}