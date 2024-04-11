using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
                break;

            Console.WriteLine("Enter duration in seconds:");
            int duration = int.Parse(Console.ReadLine());

            MindfulnessActivity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(duration);
                    break;
                case 2:
                    activity = new ReflectionActivity(duration);
                    break;
                case 3:
                    activity = new ListingActivity(duration);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    continue;
            }

            activity.Start();
        }

        Console.WriteLine("Goodbye!");
    }
}