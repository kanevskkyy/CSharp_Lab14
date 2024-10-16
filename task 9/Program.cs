using System;

class Task
{
    static void Main()
    {
        Func<int, List<int>, bool> findDividers = (number, dividers) =>
        {
            bool allDivide = true;
            foreach(int dividor in dividers)
            {
                if(number % dividor != 0) allDivide = false;
            }
            return allDivide;
        };

        Console.Write("Enter size = ");
        int size = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for(int i = 1; i <= size; i++)
        {
            numbers.Add(i);
        }

        Console.Write("Dividors = ");
        List<int> dividors = new List<int>();
        string[] enteredDividors = Console.ReadLine().Split();
        for (int i = 0; i < enteredDividors.Length; i++) 
        {
            dividors.Add(int.Parse(enteredDividors[i]));
        }
        Line();

        Console.Write("Result = ");
        foreach(int number in numbers)
        {
            if (findDividers(number, dividors)) Console.Write($"{number} ");
        }
        Console.WriteLine();
        Line();
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}