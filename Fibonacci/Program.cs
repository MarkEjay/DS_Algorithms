using System;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();
            Console.WriteLine(fibIt(6));
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        public static int fibRec(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fibRec(n - 1)+ fibRec(n-2);
            }
        }

        //public static long fibIt(int n)
        //{
        //    long[] fib = new long[n+1];
        //    fib[0] = 0;
        //    fib[1] = fib[2]= 1;

        //    for(long i=3; i<=n; i++)
        //    {
        //        fib[i] = fib[i - 1] + fib[i - 2];
        //    }
        //    return fib[n];
        //}

        public static long fibIt(int n)
        {
            long a = 1;
            long b = 1;

            for (long i = 3; i <= n; i++)
            {
                long ans = a + b;
                a = b;
                b = ans;
            }
            return b;
        }
    }


}
