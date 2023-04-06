using System;

class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, DateTime date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    
    public virtual string GetStandardDetails()
    {
        return $"Event Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDetails()
    {
        return $"Type: Event\nEvent Title: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}