using System;
using System.Collections.Generic;

public class Word
{
    private List<string> wordIndex;

    public Word()
    {
        wordIndex = new List<string>();
    }

    public void indexWords(string content)
    {
        wordIndex = new List<string>();
        string[] words = content.Split(' ');

        foreach(string word in words)
        {
            wordIndex.Add(word);
        }
    }
    public int getLength()
    {
        return wordIndex.Count;
    }

    public List<string> getWords()
    {
        return wordIndex;
    }
}