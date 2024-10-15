using System;

class Task
{
    static void Main()
    {
        Action<string[]> addSir = (strings) =>
        {
            foreach(string name in strings)
            {
                Console.WriteLine($"Sir, {name}");
            }
        };

        string[] strings = Console.ReadLine().Split();

        Line();
        addSir(strings);

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}