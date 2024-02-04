using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string date)
    {
        entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved to file successfully!");
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear(); // Clear existing entries before loading from file
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split('|');
                if (line.Length == 3)
                {
                    entries.Add(new Entry(line[1], line[2], line[0]));
                }
            }
        }
        Console.WriteLine("Journal loaded from file successfully!");
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string[] prompts = {
                        "What made you smile today?",
                        "Describe a challenge you faced and how you overcame it.",
                        "What is a new thing you learned today?",
                        "If you could travel anywhere, where would you go and why?",
                        "What is a small act of kindness you witnessed or did today?"
                    };
                    string randomPrompt = prompts[random.Next(prompts.Length)];

                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(randomPrompt, response, DateTime.Now.ToString());
                    break;

                case 2:
                    journal.DisplayEntries();
                    break;

                case 3:
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case 4:
                    Console.Write("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
