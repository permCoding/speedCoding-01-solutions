using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            string s = new string(' ', i) + "X" + new string(' ', n-2-i) + "X";
            Console.WriteLine(s);
        }
        Console.WriteLine(new string('X', n));

        Console.ReadLine();
    }
}