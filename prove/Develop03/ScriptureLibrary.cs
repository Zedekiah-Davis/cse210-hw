class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private Random random;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
        random = new Random();
        // Add 10 scriptures
        scriptures.Add(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));
        scriptures.Add(new Scripture("Psalm 23:1", "The Lord is my shepherd, I lack nothing."));
        scriptures.Add(new Scripture("Philippians 4:13", "I can do all this through him who gives me strength."));
        scriptures.Add(new Scripture("Romans 8:28", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."));
        scriptures.Add(new Scripture("Matthew 28:19-20", "Therefore go and make disciples of all nations, baptizing them in the name of the Father and of the Son and of the Holy Spirit, and teaching them to obey everything I have commanded you. And surely I am with you always, to the very end of the age."));
        scriptures.Add(new Scripture("Isaiah 41:10", "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand."));
        scriptures.Add(new Scripture("1 Corinthians 13:4-7", "Love is patient, love is kind. It does not envy, it does not boast, it is not proud. It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. Love does not delight in evil but rejoices with the truth. It always protects, always trusts, always hopes, always perseveres."));
        scriptures.Add(new Scripture("Jeremiah 29:11", "For I know the plans I have for you,” declares the Lord, “plans to prosper you and not to harm you, plans to give you hope and a future."));
        scriptures.Add(new Scripture("Ephesians 2:8-9", "For it is by grace you have been saved, through faith—and this is not from yourselves, it is the gift of God— not by works, so that no one can boast."));
    }

    public Scripture GetRandomScripture()
    {
        return scriptures[random.Next(scriptures.Count)];
    }
}