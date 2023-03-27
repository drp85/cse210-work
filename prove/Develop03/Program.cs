using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture ActiveScripture = Scripture.UserInput();

        Console.Clear();
        ActiveScripture.VerseAndText();

        bool repeat = true;
        while (repeat)
        {
            Console.Clear();

            Console.WriteLine("\nPress enter to hide a few words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input == "quit")
            {
                repeat = false;
            }
            else
            {
                int numWordsToHide = Word.scriptureTotal / 20;
                Random random = new Random();
                
                for (int i = 0; i < numWordsToHide; i++)
                {
                    int randomIndex = random.Next(Word.scriptureTotal);
                    ActiveScripture._text = ActiveScripture._text.Replace(Word.wordIndex[randomIndex], new string('_', Word.wordIndex[randomIndex].Length));
                }

                Console.Clear();
                ActiveScripture.VerseAndText();
            }
        }
    }
}