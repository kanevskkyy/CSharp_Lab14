using System;
using task_11;
class Task
{
    static void Main()
    {
        Action<List<Filter>, string, string> RemoveFilter = (filters, filterType, parameter) =>
        {
            for (int i = 0; i < filters.Count; i++)
            {
                if (filters[i].FilterType == filterType && filters[i].Parameter == parameter)
                {
                    filters.RemoveAt(i);
                    break;
                }
            }
        };

        Func<List<string>, string, string, List<string>> ApplyFilter = (guests, filterType, parameter) =>
        {
            List<string> filteredGuests = new List<string>();

            foreach (var guest in guests)
            {
                bool shouldAdd = true;
                switch (filterType)
                {
                    case "Starts with":
                        if (guest.StartsWith(parameter)) shouldAdd = false;
                        break;
                    case "Ends with":
                        if (guest.EndsWith(parameter)) shouldAdd = false;
                        break;
                    case "Length":
                        if (guest.Length == int.Parse(parameter)) shouldAdd = false;
                        break;
                    case "Contains":
                        if (guest.Contains(parameter)) shouldAdd = false;
                        break;
                }
                if (shouldAdd)
                {
                    filteredGuests.Add(guest);
                }
            }
            return filteredGuests;
        };

        List<string> guests = new List<string>(Console.ReadLine().Split());
        List<Filter> filters = new List<Filter>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Print")  break;
            
            string[] commandParts = input.Split(';');
            string command = commandParts[0];  
            string filterType = commandParts[1];    
            string filterParameter = commandParts[2];

            if (command == "Add filter") filters.Add(new Filter(filterType, filterParameter));
            else if (command == "Remove filter") RemoveFilter(filters, filterType, filterParameter);
        }

        foreach (var filter in filters)
        {
            guests = ApplyFilter(guests, filter.FilterType, filter.Parameter);
        }

        if (guests.Count == 0) Console.WriteLine("Nobody is going to the party!"); 
        else
        {
            foreach(string guest in guests)
            {
                Console.Write(guest + ", ");
            }
            Console.Write("are going to the party!");
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}