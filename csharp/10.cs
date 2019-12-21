using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = n;
        if (n > 1) r *= n - 1;
        if (n > 2) r *= n - 2;
        Console.WriteLine(r);
        Console.ReadLine();
    }
}