public class Event
{
    public string EventTitle { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public Event(string eventTitle, string description, DateTime date, string time, Address address)
    {
        EventTitle = eventTitle;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event Title: {EventTitle}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address.GetFullAddress()}";
    }
}