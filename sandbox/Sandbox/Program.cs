using System;
//bro. manley is in 330F
class Program
{
    static void Main(string[] args)
    {
        bool pausing = true;
        while (pausing)
        {
            Console.WriteLine("  o  \no   o\n  o  ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("o   o\n\no   o");
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}