using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.ReadLine();
        int r = 0;
        for (int i = 0; i < n-2; i++)
        {
            r += Console.ReadLine().ToCharArray().Count(x => x == 'X') - 2;
        }
        Console.ReadLine();

        Console.WriteLine(r);
        Console.ReadLine();
    }
}