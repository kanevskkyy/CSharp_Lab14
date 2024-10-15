using System;

class Task
{
    static void Main()
    {
        Func<int[], int> calculateMin = (array) =>
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++) 
            {
                if(min > array[i]) min = array[i];
            }
            return min;
        };

        string[] numbers = Console.ReadLine().Split();
        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }
        Line();
        Console.WriteLine($"Min number = {calculateMin(array)}");
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}