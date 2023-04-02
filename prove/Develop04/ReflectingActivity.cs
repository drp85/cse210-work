using System;

public class ReflectingActivity : Activity
{ 
    
    private List<string> prompts;
    private string GetPrompt()
    {
        prompts = new List<string> {"Think of a time when you stood up for someone else. " , "Think of a time when you did something really difficult. " , "Think of a time when you helped someone in need." , "Think of a time when you did something truly selfless."};
        
        Random random = new Random();

        int total = prompts.Count();
        int num = random.Next(total);
        string prompt = prompts[num];
        return prompt;
    }

    private List<string> questions;
    private string GetQuestion()
    {
        questions = new List<string> {"Why was this experience meaningful to you?" , "Have you ever done anything like this before?" , "How did you get started?" , "How did you feel when it was complete?" , "What made this time different than other times when you were not as successful?" , "What is your favorite thing about this experience?" , "What could you learn from this experience that applies to other situations?" , "What did you learn about yourself through this experience?" , "How can you keep this experience in mind in the future?"};

        Random random = new Random();

        int total = questions.Count();
        int num = random.Next(total);
        string question = questions[num];
        return question;
    }

    public void run()
    {
        Console.WriteLine("How many seconds would you like for the excersize to last?");
        int length = Int16.Parse(Console.ReadLine()) * 1000;
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length/1000);

        while (DateTime.Now < endTime)
        {
        string prompt = GetPrompt();
        Console.WriteLine(prompt);
        int time = 5000;
        Thread.Sleep(2500);
        pause(time);
        
        string question = GetQuestion();
        Console.WriteLine(question);
        Thread.Sleep(2500);
        pause(time);
        }
        
        end();
    }
}