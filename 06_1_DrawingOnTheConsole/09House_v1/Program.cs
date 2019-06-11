using System;

namespace _09House_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diff = n % 2 == 0 ? 0 : 1;

            int roofHeight = (int)Math.Ceiling(n / 2f); //5/2->38/2->4


            Console.Write(new string('-', (n - diff) / 2));
            Console.Write(new string('*', 1 + diff));
            Console.WriteLine(new string('-', (n - diff) / 2));

            for (int row = 1; row < roofHeight; row++)
            {

                Console.Write(new string('-', roofHeight - row));
                Console.Write(new string('*', row * 2 - diff));
                Console.WriteLine(new string('-', roofHeight - row));

            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }

    }
}
