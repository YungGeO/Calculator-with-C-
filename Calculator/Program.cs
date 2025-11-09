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
            switch (choice)
            {
                case "1":
                case "add":
                    break;
                case "2":
                case "sub":
                    break;
                case "3":
                case "mul":
                    break;
                case "4":
                case "div":
                    break;
                case "5":
                case "power":
                    break;
                case "6":
                case "quit":
                    break;
                default:
                    Console.WriteLine("invalid choice.Try again \n");
                    break;
            }
        }
    }
}
