using System;

class Task
{
    static void Main()
    {
        Func<int[], int[]> addOne = (array) =>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
            return array;
        };

        Func<int[], int[]> multipy = (array) =>
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            return array;
        };

        Func<int[], int[]> subtract = (array) =>
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }
            return array;
        };

        Action<int[]> printNumbers = (array) =>
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        };

        Console.Write("Enter numbers = ");
        string[] numbers = Console.ReadLine().Split();
        int[] array = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++) 
        {
            array[i] = int.Parse(numbers[i]);
        }
        Line();

        while (true)
        {
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "add":
                    array = addOne(array);
                    break;
                case "multiply":
                    array = multipy(array);
                    break;
                case "subtract":
                    array = subtract(array);
                    break;
                case "print":
                    printNumbers(array);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
            Line();
        }
        Line();
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}