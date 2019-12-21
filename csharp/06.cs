using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = 2 * n + 3;
        string z = new string('X', r);
        Console.WriteLine(z);
        for (int i = 0; i<2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                string a = "X" + new string(' ', n) + "X" + new string(' ', n) + "X";
                Console.WriteLine(a);
            }
            Console.WriteLine(z);
        }
        Console.ReadLine();
    }
}