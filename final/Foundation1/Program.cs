using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Printing Videos and Comments:");

        Video videos = new Video();
        Comment comments = new Comment();

        int key = videos.getKeyTotal();
        while (key > 0)
        {
            if (videos.video.ContainsKey(key))
            {
                videos.display(key);
            }
            if (comments.comments.ContainsKey(key))
            {
                comments.display(key);
            }
            key = key - 1;
        }
    }
}
