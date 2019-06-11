using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 > 0) //even
        {
            for (int row = 1; row <= n / 2 + 1; row++)
            {
                Console.Write(new string('-', n / 2 - row + 1));
                Console.Write(new string('*', row * 2 - 1));
                Console.WriteLine(new string('-', n / 2 - row + 1));
            }
        }
        else
        {
            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string('-', n / 2 - row));
                Console.Write(new string('*', row * 2));
                Console.WriteLine(new string('-', n / 2 - row));
            }
        }

        for (int row = 1; row <= n / 2; row++)
        {
            Console.Write("|");
            Console.Write(new string('*', n - 2));
            Console.WriteLine("|");
        }
    }
}

