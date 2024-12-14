using System;

namespace CodeForce
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            // n = int.Parse(Console.ReadLine());
            n = 1;
            for (int i = 0; i < n; i++)
            {
                Solve();
            }
            
        }

        static public void Solve()
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            long n = int.Parse(values[0]);
            long m = int.Parse(values[1]);
            long a = int.Parse(values[2]);

            long res = 0;
            // Console.WriteLine($"n/a = {(double)n/a}");
            // Console.WriteLine($"m/a = {(double)m/a}");
            long w = n / a;
            long h = m / a;

            if (n % a != 0) w += 1;
            if (m % a != 0) h += 1;
            
            res = w * h;
            Console.WriteLine(res);
        }
    }
    
    
}