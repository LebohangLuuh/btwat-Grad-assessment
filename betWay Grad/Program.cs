using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] shelf = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Console.WriteLine(CanOrganizeIntoSets(shelf) ? "YES" : "NO");
    }

    static bool CanOrganizeIntoSets(int[] shelf)
    {
        if (shelf.Length == 0) return false;
        
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int book in shelf)
        {
            if (book > 0) 
                freq[book] = freq.GetValueOrDefault(book, 0) + 1;
        }

        if (freq.Count == 0) return false;

        int gcd = freq.Values.Aggregate(GCD);
        
        return gcd > 1;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
