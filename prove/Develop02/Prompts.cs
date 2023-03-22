using System;

public class Prompt
{
    private List<string> prompts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What could I have done to make someone else's day better?",
        "What do I wish I hadn't done today?",
        "What did I do to better myself today?",
        "What can I do better tommorrow that I didn't feel great about today?",
        "If I hadn't made any mistakes today, what would be different?",
        "How did I make someone else's day better today?",
        "How did I feel at my peak and pit today?",
        "What did someone do to make my day better?",
    };
    
    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}