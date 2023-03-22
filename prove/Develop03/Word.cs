using System;
using System.Collections.Generic;

public class Word
{
    public void IndexWords(string content)
    {
        string[] words = content.Split(' ');

        Dictionary<int, string> wordIndex = new Dictionary<int, string>();
        for (int i = 0; i < words.Length; i++)
        {
            wordIndex.Add(i, words[i]);
        }
    }
}