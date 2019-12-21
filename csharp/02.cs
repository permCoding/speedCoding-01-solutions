using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] nums = s.Select(x => int.Parse(x)).Where(x => x % 2 == 0).ToArray();
        Console.Write(nums[0]);
    }
}