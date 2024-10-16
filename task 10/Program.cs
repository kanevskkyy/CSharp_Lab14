using System;
using System.Reflection.Metadata;

class Task
{
    static void Main()
    {
        Func<string, string, string, bool> MatchesCriterion = (guest, criterion, parameter) =>
        {
            switch (criterion)
            {
                case "StartsWith":
                    return guest.StartsWith(parameter);
                case "EndsWith":
                    return guest.EndsWith(parameter);
                case "Length":
                    return guest.Length == int.Parse(parameter);
                default:
                    return false;
            }
        };


        Func<List<string>, string, string, List<string>> RemoveGuests = (guests, criterion, parametr) =>
        {
            var result = from guest in guests
                         where !MatchesCriterion(guest, criterion, parametr)
                         select guest;
            return result.ToList();

        };

        Func<List<string>, string, string, List<string>> DoubleGuests = (guests, criterion, parameter) =>
        {
            List<string> result = new List<string>(guests);

            foreach (string guest in guests)
            {
                if (MatchesCriterion(guest, criterion, parameter))
                {
                    result.Add(guest);
                }
            }
            return result;
        };

        List<string> guests = Console.ReadLine().Split().ToList();
        while (true)
        {
            string[] command = Console.ReadLine().Split();
            if (command[0] == "Party!") break; 
            
            string action = command[0]; 
            string criterion = command[1];
            string parameter = command[2];

            if (action == "Remove") guests = RemoveGuests(guests, criterion, parameter);
            else if (action == "Double") guests = DoubleGuests(guests, criterion, parameter);
        }

        if (guests.Count == 0) Console.WriteLine("Nobody is going to the party!");
        else
        {
            guests.Sort();
            foreach (string guest in guests)
            {
                Console.Write($"{guest}, ");
            }
            Console.Write("are going to the party");
        }
        
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}