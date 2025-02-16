using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine() ?? string.Empty;
        if (input == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }
        int[] outcomes = Array.ConvertAll(input.Split(), int.Parse);
        
        int[] duplicates = FindDuplicates(outcomes);
        
        Console.WriteLine(string.Join(" ", duplicates));
    }

    static int[] FindDuplicates(int[] outcomes)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> duplicates = new List<int>();
        
        foreach (int outcome in outcomes)
        {
            if (seen.Contains(outcome))
            {
                duplicates.Add(outcome);
                if (duplicates.Count == 2) 
                    break;
            }
            else
            {
                seen.Add(outcome);
            }
        }
        
        return duplicates.ToArray();
    }
}