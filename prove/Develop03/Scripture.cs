using System;
using System.Text.RegularExpressions;

public class Scripture
{
    public string _verse { get; set; }
    public string _text { get; set;}

    public Scripture(string verse, string text)
    {
        verse = _verse;
        text = _text;
    }

    public static Scripture UserInput(Scripture neph1_1, Scripture neph11_16_17)
    {
        Console.WriteLine("Please select the verse you want to memorize:\n");
        Console.WriteLine("1. 1 Nephi 1:1\n");
        Console.WriteLine("2. 1 Nephi 11:16-17\n");

        int activeScripture = Console.Read();
        
        switch (activeScripture)
        {   
            case '1':
                return neph1_1;
            case '2':
                return neph11_16_17;
            default:
                Console.WriteLine("Invalid Selection.");
                return null;    
        }
    }

    public void VerseAndText()
    {
        Console.WriteLine($"{_verse}\n");
        
        string pattern = @"^\d+\.\s+";
        string[] parts = Regex.Split(_text, pattern, RegexOptions.Multiline);
        
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
        
    }
}