using System;
using System.Collections.Generic;

public class Word
{
    public static Dictionary<int, string> wordIndex = new Dictionary<int, string>();

    public static int scriptureTotal { get; set; }

    public static void IndexWords(string content)
    {
        string[] words = content.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            wordIndex.Add(i, words[i]);
        }

        scriptureTotal = words.Length;
    }
}