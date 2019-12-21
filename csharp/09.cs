using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = Console.ReadLine().Split();

        int i;
        for (i = 0; i < n; i++)
        {
            if (arr.Count(e => e == arr[i]) == 1)
            {
                break;
            }
        }
        Console.WriteLine(arr[i]);
        Console.ReadLine();
    }
}