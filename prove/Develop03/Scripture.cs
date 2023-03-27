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

        int numWordsToHide = word.getLength() / 20;
        Random random = new Random();
        
        for (int i = 0; i < numWordsToHide; i++)
        {
            //need to make random word hider and maintain hidden words and display words
        
        }
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