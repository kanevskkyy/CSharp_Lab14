using System;
using System.Collections.Generic;

namespace task_12
{
    class Program
    {
        static void Main()
        {
            Func<List<int>, string, int, int, bool> shouldExclude = (gems, filterType, parameter, index) =>
            {
                int left = 0;
                int right = 0;
                int current = gems[index];

                if (index > 0) left = gems[index - 1];
                if (index < gems.Count - 1) right = gems[index + 1];
                if (filterType == "Sum Left")
                {
                    if (left + current == parameter) return true;
                }
                else if (filterType == "Sum Right")
                {
                    if (right + current == parameter) return true;
                }
                else if (filterType == "Sum Left Right")
                {
                    if (left + current + right == parameter) return true;
                }

                return false;
            };

            Func<List<int>, List<Filter>, List<int>> applyFilters = (gems, filters) =>
            {
                List<int> result = new List<int>(gems);
                List<int> excludedIndices = new List<int>();
                foreach (var filter in filters)
                {
                    for (int i = 0; i < gems.Count; i++)
                    {
                        if (shouldExclude(gems, filter.FilterType, int.Parse(filter.Parameter), i) && !excludedIndices.Contains(i))
                        {
                            excludedIndices.Add(i);
                        }
                    }
                }
                for (int i = 0; i < excludedIndices.Count - 1; i++)
                {
                    for (int j = i + 1; j < excludedIndices.Count; j++)
                    {
                        if (excludedIndices[i] < excludedIndices[j])
                        {
                            int temp = excludedIndices[i];
                            excludedIndices[i] = excludedIndices[j];
                            excludedIndices[j] = temp;
                        }
                    }
                }
                foreach (int index in excludedIndices)
                {
                    result.RemoveAt(index);
                }

                return result;
            };

            string[] input = Console.ReadLine().Split();
            List<int> gems = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                gems.Add(int.Parse(input[i]));
            }

            List<Filter> filters = new List<Filter>();
            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "Forge") break;

                string[] commandParts = commandInput.Split(';');
                string command = commandParts[0];
                string filterType = commandParts[1];
                string parameter = commandParts[2];

                if (command == "Exclude")
                {
                    filters.Add(new Filter(filterType, parameter));
                }
                else if (command == "Reverse")
                {
                    for (int i = 0; i < filters.Count; i++)
                    {
                        if (filters[i].FilterType == filterType && filters[i].Parameter == parameter)
                        {
                            filters.RemoveAt(i);
                            break;
                        }
                    }
                }
            }

            List<int> result = applyFilters(gems, filters);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
