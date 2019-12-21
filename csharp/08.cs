using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = 0;
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            if (s.Length == s.ToCharArray().Distinct().Count())
            {
                r++;
            }
        }
        Console.WriteLine(r);
        Console.ReadLine();
    }
}