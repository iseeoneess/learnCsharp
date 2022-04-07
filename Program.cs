using System;

namespace zalupa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                int s = i;
                int[] arr = new int[s];
                s = s / 10;
                int n = 1;
                foreach (int k in arr)
                {
                    while (s < 51)
                    {
                        s = s + 5;
                        n *= 2;
                    }
                    if (n == 64)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
        }
    }
}