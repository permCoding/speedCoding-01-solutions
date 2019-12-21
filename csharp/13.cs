using System;
//using System.Diagnostics; 
		// можете измерить время работы
        // до h == 2*10**8 - простое решение
        // от h == 2*10**9 - сложное решение

class P
{
    static void Main()
    {
        string[] items = Console.ReadLine().Split();
        int n = int.Parse(items[0]);
        int m = int.Parse(items[1]);
        int h = int.Parse(items[2]);

        //Stopwatch stopWatch = new Stopwatch();
        //stopWatch.Start();

        if (h > n)
        {
            if (m >= n)
            {
                Console.Write("NO");
            }
            else
            {
                int count = 1;
                while (true)
                {
                    h -= n;
                    if (h < 1) break;
                    h += m;
                    count++;
                }
                Console.Write(count);
            }
        }
        else
        {
            Console.Write(1);
        }

        //stopWatch.Stop();
        //TimeSpan ts = stopWatch.Elapsed;
        //string t = string.Format("\n{0:00}:{1:00}:{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        //Console.WriteLine(t);
        Console.ReadLine();
    }
}