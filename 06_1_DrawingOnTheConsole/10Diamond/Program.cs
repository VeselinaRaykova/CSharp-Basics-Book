using System;

namespace _10Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diff = n % 2 == 0 ? 1 : 0;

            int topHeight = (int)Math.Ceiling(n / 2f); //5/2->38/2->4

            Console.Write(new string('-', (n - diff) / 2));
            Console.Write(new string('*', 1 + diff));
            Console.WriteLine(new string('-', (n - diff) / 2));

            for (int row = 1; row < topHeight; row++)
            {
                Console.Write(new string('-', topHeight - row - 1));
                Console.Write("*");
                Console.Write(new string('-', 2 * row - 1 + diff));
                Console.Write("*");
                Console.WriteLine(new string('-', topHeight - row - 1));
            }

            for (int row = 1; row <= n / 2 - diff; row++)
            {
                Console.Write(new string('-', row));

                if (row != n / 2 - diff)
                {
                    Console.Write("*");
                    Console.Write(new string('-', n - 2 * row - 2));
                    Console.Write("*");
                }
                else
                {
                    Console.Write(new string('*', 1 + diff));
                }

                Console.WriteLine(new string('-', row));
            }
        }
    }
}
