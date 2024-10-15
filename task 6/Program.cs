using System;

class Task
{
    static void Main()
    {
        Func<int[], int[]> reverseCollection = (array) =>
        {
            int[] result = new int[array.Length];
            int counter = 0;
            for(int i = array.Length - 1; i >= 0; i--)
            {
                result[counter] = array[i];
                counter++;
            }
            return result;
        };

        Func<int, int, bool> isDivide = (number, divider) => number % divider == 0;
        Console.Write("Enter numbers = ");
        string[] numbers = Console.ReadLine().Split();
        Console.Write("Enter divider = ");
        int divider = int.Parse(Console.ReadLine());
        
        int[] array = new int[numbers.Length];
        for(int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        Line();
        array = reverseCollection(array);

        foreach(int number in array)
        {
            if(isDivide(number, divider)) Console.Write(number + " ");
        }
        Console.WriteLine();
        Line();
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}