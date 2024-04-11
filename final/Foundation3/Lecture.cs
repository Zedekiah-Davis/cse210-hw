public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string eventTitle, string description, DateTime date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetStandardDetails()
    {
        return base.GetStandardDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}