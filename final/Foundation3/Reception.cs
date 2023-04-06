using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string eventTitle, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}