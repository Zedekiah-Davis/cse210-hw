using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
                Console.WriteLine("Journal saved successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split('|');
                    if (entryData.Length == 3)
                    {
                        Entry loadedEntry = new Entry(entryData[1], entryData[2])
                        {
                            Date = entryData[0]
                        };
                        entries.Add(loadedEntry);
                    }
                }
                Console.WriteLine("Journal loaded successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select a prompt:");
                    Console.WriteLine("1. Who was the most interesting person I interacted with today?");
                    Console.WriteLine("2. What was the best part of my day?");
                    Console.WriteLine("3. How did I see the hand of the Lord in my life today?");
                    Console.WriteLine("4. What was the strongest emotion I felt today?");
                    Console.WriteLine("5. If I had one thing I could do over today, what would it be?");
                    int promptChoice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your response:");
                    string response = Console.ReadLine();

                    switch (promptChoice)
                    {
                        case 1:
                            journal.AddEntry("Who was the most interesting person I interacted with today?", response);
                            break;
                        case 2:
                            journal.AddEntry("What was the best part of my day?", response);
                            break;
                        case 3:
                            journal.AddEntry("How did I see the hand of the Lord in my life today?", response);
                            break;
                        case 4:
                            journal.AddEntry("What was the strongest emotion I felt today?", response);
                            break;
                        case 5:
                            journal.AddEntry("If I had one thing I could do over today, what would it be?", response);
                            break;
                        default:
                            Console.WriteLine("Invalid prompt choice.");
                            break;
                    }
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to load:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case "4":
                    Console.WriteLine("Enter the filename to save:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
