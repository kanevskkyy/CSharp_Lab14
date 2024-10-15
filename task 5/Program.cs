using System;

class Task
{
    static void Main()
    {
        Func<int[], int[]> addOne = (array) =>
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
            return array;
        };

        Func<int[], int[]> multipy


    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}