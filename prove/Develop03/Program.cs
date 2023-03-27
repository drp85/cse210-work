using System;
class Program
{
    static void Main(string[] args)
    {
        
        Reference references = new Reference();
        
        Console.Clear();
        Console.WriteLine("Please select the verse you want to memorize:\n");
        references.displayReferences();

        int response = Int16.Parse(Console.ReadLine());
        Scripture scripture = references.getScripture(response);

        Console.Clear();
        Console.WriteLine($"{scripture.asString()}");

        Word word = new Word();
        word.indexWords(scripture.getText());

        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("\nPress enter to hide a few words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                repeat = false;
            }
            else
            {
                Console.Clear();
                
                scripture.scriptureMemorize(word);
                

            }
        }
    }
}