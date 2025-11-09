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
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sub");
            Console.WriteLine("3. Mul");
            Console.WriteLine("4. Div");
            Console.WriteLine("5. Power");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Enter option");
            string choice = Console.ReadLine()?.Trim().ToLower();
        }
    }
}
