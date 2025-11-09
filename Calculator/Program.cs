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
                    Add();
                    break;
                case "2":
                case "sub":
                    Sub();
                    break;
                case "3":
                case "mul":
                    Mul();
                    break;
                case "4":
                case "div":
                    Div();
                    break;
                case "5":
                case "power":
                    Pow();
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
    static (double, double) GetTwoNumbers()
    {
        Console.Write("Enter first number: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double y = double.Parse(Console.ReadLine());

        return (x, y);
    }
    static void Add()
    {
        (double x, double y) = GetTwoNumbers();
        double result = x + y;
        Console.WriteLine($"Result: {result}\n");
    }
    static void Sub()
    {
        (double x, double y) = GetTwoNumbers();
        double result = x - y;
        Console.WriteLine($"Result: {result}\n");
    }
    static void Mul()
    {
        (double x, double y) = GetTwoNumbers();
        double result = x * y;
        Console.WriteLine($"Result: {result}\n");
    }
    static void Div()
    {
        (double x, double y) = GetTwoNumbers();
        if (y == 0)
        {
            Console.WriteLine("Can not divide by zero ,give another number! \n");
            return;
        }
        double result = x / y;
        Console.WriteLine($"Result: {result}\n");
    }
    static void Pow()
    {
        (double x, double y) = GetTwoNumbers();
        double result = Math.Pow(x, y);
        Console.WriteLine($"Result: {x}^{y} = {result}\n");
    }
}
