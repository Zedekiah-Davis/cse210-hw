using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

        Scripture scripture = scriptureLibrary.GetRandomScripture();
        Console.WriteLine("Scripture: ");
        scripture.Display();

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            bool wordHidden = scripture.HideRandomWord();
            if (!wordHidden)
            {
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                break;
            }

            Console.Clear();
            Console.WriteLine("Scripture: ");
            scripture.Display();
        }
    }
}