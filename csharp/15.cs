using System;
using System.Linq;

class Program
{
    static int get(int N, int K)
    {
        if (K == 0)
            return (N == 0) ? 1 : 0;
        if (N == 0)
            return 0;
        return get(N - 1, K - 1) + get(N + 1, K - 1);
    }

    static void Main()
    {
        int[] par = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int n = par[0], k = par[1];
        Console.WriteLine(get(n, k));
        Console.ReadLine();
    }
}