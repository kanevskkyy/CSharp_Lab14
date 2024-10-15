using System;

class Task
{
    static void Main()
    {
        Action<string[]> showStrings = (strings) =>
        {
            foreach(string name in strings)
            {
                Console.WriteLine(name);
            }
        };
        string[] strings = Console.ReadLine().Split();

        Line();
        showStrings(strings);
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}