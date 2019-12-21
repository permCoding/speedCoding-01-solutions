using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        HashSet<char> a = new HashSet<char>();
        int r = -1;
        for (int i = 0; i<s.Length; i++)
        {
            a.Add(s[i]);
            if (a.Count>9)
            {
                r = i + 1;
                break;
            }
        }
        if (r < 0)
            Console.WriteLine("fail");
        else
            Console.WriteLine(r);
    }
}