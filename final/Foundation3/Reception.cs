public class Reception : Event
{
    public string RSVPContactEmail { get; set; }

    public Reception(string eventTitle, string description, DateTime date, string time, Address address, string rsvpContactEmail) : base(eventTitle, description, date, time, address)
    {
        RSVPContactEmail = rsvpContactEmail;
    }

    public override string GetStandardDetails()
    {
        return base.GetStandardDetails() + $"\nRSVP Contact Email: {RSVPContactEmail}";
    }
}