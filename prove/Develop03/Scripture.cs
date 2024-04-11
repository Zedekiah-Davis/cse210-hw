class Scripture
{
    private string reference;
    private List<string> words;
    private List<bool> hiddenWords;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').ToList();
        this.hiddenWords = Enumerable.Repeat(false, words.Count).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference);
        for (int i = 0; i < words.Count; i++)
        {
            if (hiddenWords[i])
                Console.Write("____ ");
            else
                Console.Write(words[i] + " ");
        }
        Console.WriteLine("\n");
    }

    public bool HideRandomWord()
    {
        int countHidden = hiddenWords.Count(w => w);
        if (countHidden == hiddenWords.Count)
            return false; // All words are already hidden

        Random random = new Random();
        int index;
        do
        {
            index = random.Next(words.Count);
        } while (hiddenWords[index]); // Ensure we're not hiding an already hidden word

        hiddenWords[index] = true;
        return true;
    }

    public bool AllWordsHidden()
    {
        return hiddenWords.All(w => w);
    }
}