using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write(string.Join(" ", Console.ReadLine().Split().Take(2)));
    }
}