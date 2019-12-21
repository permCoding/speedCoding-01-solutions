using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        int[] d = new int[10];

        List<int> lst = s.Split(' ').Select(x => int.Parse(x)).ToList();

        foreach (int i in lst)
        {
            d[i] += 1;
        }

        string first = "9";
        for (int i = 1; i < 10; i++)
        {
            if (d[i] > 0)
            {
                first = i.ToString();
                d[i] -= 1;
                break;
            }
        }

        string result = first;
        for (int i=0; i<10; i++)
        {
            result += new string((char)(48 + i), d[i]);
        }

        Console.WriteLine(result);
    }
}