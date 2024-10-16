using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Task
{
    static void Main()
    {
        Func<int, int, int> customComparator = (x, y) =>
        {
            if ((x % 2 == 0 && y % 2 == 0) || (x % 2 != 0 && y % 2 != 0))
            {
                return x.CompareTo(y);
            }
            else if (x % 2 == 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        };

        Console.Write("Enter array = ");
        string[] numbers = Console.ReadLine().Split();

        int[] array = new int[numbers.Length];
        for(int i = 0; i < numbers.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }

        Array.Sort(array, new Comparison<int>(customComparator));
        Console.Write("Sorted array : ");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}