using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        List<string> lst = s.Split(' ').OrderBy(x => x).ToList();
        int countZero = lst.Count(e => e == "0");
        string result = lst[countZero] + new string('0', countZero) + string.Join("", lst.Skip(countZero+1));

        Console.WriteLine(result);
        Console.ReadLine();
    }
}