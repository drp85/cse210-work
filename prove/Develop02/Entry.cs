using System;

public class Entry
{
    private DateTime _date;
    private string _prompt;
    private string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        _response = response;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }
}
