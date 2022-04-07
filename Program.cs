using System;

namespace zalupa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                int x = i;
                int q = 9;
                int l = 0;
                while (x >= q)
                {
                    l += 1;
                    x -= q;
                }
                int m = x;
                if (m < l)
                {
                    m = l;
                    l = x;
                }
                if (l == 4 && m == 5)
                {
                    Console.WriteLine();
                }

            }
            Console.ReadLine();

        }
    }
}