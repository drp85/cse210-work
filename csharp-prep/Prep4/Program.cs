using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, end by entering 0.");
        
        Boolean end = false;
        
        while (end == false)
        {
        string num = Console.ReadLine();
        int intnum = Int16.Parse(num);
        if (intnum == 0)
        {
            end = true;
        }
        else
        {
        
        numbers.Add(intnum);
        }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the list is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");
        int max =  numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;   
            }
        }
        Console.WriteLine($"The max is {max}");
            }
}