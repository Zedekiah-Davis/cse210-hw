public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        ShowStartingMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("Start listing...");

        // Assume user lists items manually, no need for automated countdown

        Console.WriteLine("Enter the number of items you listed:");
        int itemCount = int.Parse(Console.ReadLine());
        Console.WriteLine($"You listed {itemCount} items.");

        ShowEndingMessage();
    }
}