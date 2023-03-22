using System;
using System.Collections.Generic;

public class Journal
{
    private string filename;
    public List<Entry> entries;

    public Journal(string _filename)
    {
        this.filename = _filename;
        this.entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            if (!string.IsNullOrEmpty(line))
            {
                string[] parts = line.Split("|||");
                if (parts.Length == 2)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    Entry entry = new Entry(prompt, response);
                    this.entries.Add(entry);
                }
            }
        }
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.GetDate()} - Prompt: {entry.GetPrompt()}\n{entry.GetResponse()}\n");
        }
    }

    public void AddEntry(Entry entry)
    {
        this.entries.Add(entry);
    }

    public void SaveToFile()
    {
        string[] lines = new string[entries.Count];

        for (int i = 0; i < entries.Count; i++)
        {
            Entry entry = entries[i];
            string line = $"{entry.GetDate()}|||{entry.GetPrompt()}|||{entry.GetResponse()}";
            lines[i] = line;
        }

        System.IO.File.WriteAllLines(filename, lines);
        Console.WriteLine($"Entries saved to {filename}");
    }
}
