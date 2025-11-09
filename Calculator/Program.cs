using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name kind sir");
        string name = Console.ReadLine();
        Console.WriteLine($"welcome {name}");
        bool stopCal = true;
        while (stopCal)
        {
            Console.WriteLine($"What you want to do mr/mrs {name}");
        }
    }
}
