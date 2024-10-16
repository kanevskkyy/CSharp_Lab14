using System;

class Task
{
    static int wordSize;
    static void Main()
    {
        Predicate<string> sameLength = (name) => name.Length <= wordSize;
        Console.Write("Enter length of word = ");
        wordSize = int.Parse(Console.ReadLine());
        
        Console.Write("Enter length of word = ");
        string[] words = Console.ReadLine().Split();

        Line();
        foreach (string word in words)
        {
            if (sameLength(word)) Console.Write(word + " ");
        }
        Console.WriteLine();
        Line();

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}