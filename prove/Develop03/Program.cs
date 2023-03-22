using System;

class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;
        while (repeat)
        {
            Console.Clear();
            
            Scripture neph11 = new Scripture();
            neph11._verse = "Nephi 1:1";
            neph11._text = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";

            neph11.Display();

            Console.WriteLine("\nPress enter to hide a few words or type 'quit' to exit.");

            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                repeat = false;
            }
            else
            {
                int startIndex = 0;
                int numWordsToHide = 3;
                Random random = new Random();

                while (startIndex < neph11.WordIndex.Count)
                {
                    Console.Clear();

                    // Hide the next few words
                    for (int i = startIndex; i < startIndex + numWordsToHide && i < neph11.WordIndex.Count; i++)
                    {
                        int index = i;
                        while (neph11.HiddenWords.Contains(index))
                        {
                            // If the word is already hidden, skip it and try the next one
                            index++;
                            if (index >= neph11.WordIndex.Count)
                            {
                                break;
                            }
                        }

                        if (index < neph11.WordIndex.Count)
                        {
                            neph11.HiddenWords.Add(index);
                            neph11.WordIndex[index] = new string('*', neph11.WordIndex[index].Length);
                        }
                    }

                    neph11.Display();

                    if (neph11.HiddenWords.Count == neph11.WordIndex.Count)
                    {
                        Console.WriteLine("\nAll words are hidden. Press enter to exit.");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("\nPress enter to hide a few more words or type 'quit' to exit.");

                    input = Console.ReadLine().ToLower();

                    if (input == "quit")
                    {
                        break;
                    }

                    startIndex += numWordsToHide;
                }
            }
        }
    }
}