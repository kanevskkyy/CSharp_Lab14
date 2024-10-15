using System;

class Task
{
    static void Main()
    {
        Predicate<int> oddNumber = (number) => number % 2 == 1;
        Predicate<int> evenNumber = (number) => number % 2 == 0;

        Console.Write("Start number = ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End number = ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Even or odd = ");
        string choice = Console.ReadLine();
        Line();

        switch (choice.ToLower())
        {
            case "even":
                for(int i = start; i <= end; i++)
                {
                    if (evenNumber(i)) Console.Write(i + " ");
                }
                break;
            case "odd":
                for (int i = start; i <= end; i++)
                {
                    if (oddNumber(i)) Console.Write(i + " ");
                }
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
        Console.WriteLine();
        Line();
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}