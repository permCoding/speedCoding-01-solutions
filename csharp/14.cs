using System;

class P
{
    static void Main()
    {
        string[] items = Console.ReadLine().Split();
        int n = int.Parse(items[0]);
        int m = int.Parse(items[1]);
        int h = int.Parse(items[2]);

        if (h > n)
        {
            if (m >= n)
            {
                Console.Write("NO");
            }
            else
            {
                Console.Write((h - n - 1) / (n - m) + 2);
            }
        }
        else
        {
            Console.Write(1);
        }
    }
}