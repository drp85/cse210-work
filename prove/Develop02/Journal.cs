using System;

public class Journal
{
    private string filename;
    private List<string> entries;

    public Journal(string filename)
    {
        this.filename = filename;
        this.entries = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("\n");
            foreach (string entry in parts)
            {
                if (!string.IsNullOrEmpty(entry))
                {
                    this.entries.Add(entry);
                }
            }
        }
    }
    public void Display(){
        Console.WriteLine($"{entries}");
    }
}