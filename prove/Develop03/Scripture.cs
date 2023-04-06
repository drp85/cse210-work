using System;
using System.Text.RegularExpressions;

public class Scripture
{
    private string verse;
    private List<string> text;

    public Scripture(string verse, List<string> text)
    {
        this.verse = verse;
        this.text = text;
    }

    public string getVerse()
    {
        return verse;
    }
    
    public string getText()
    {
        return string.Join(" ", text);
    }

    public void scriptureMemorize(Word word)
    {

        int numWordsToHide = word.getLength() / 12;
        Random random = new Random();

        int total = word.getLength();
        
        
        for (int i = 0; i < numWordsToHide; i++)
        {
            int num = random.Next(total);
            if (word.getWords()[num] != "___")
            {
            word.getWords()[num] = "___";
            }  
        }

        string reconstructed = "";
        for (int j = 0; j < total; j++)
        reconstructed += $" {word.getWords()[j]}";
        word.indexWords(reconstructed);
        Console.WriteLine(reconstructed);
    }

    public string asString()
    {
        string result = verse;
        
        foreach (string part in text)
        {
            result += $"\n{part}";
        }
        return result;
    }
}