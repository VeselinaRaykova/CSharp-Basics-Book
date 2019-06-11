using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = (int)Math.Ceiling(n / 2f);
            int middleWidth = 2 * n - 2 * (n / 2) - 4;

            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            if (n > 4)
            {
                Console.Write(new string('_', middleWidth));
            }

            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");

            for (int row = 1; row <= n - 2; row++)
            {
                Console.Write("|");
                if (row == n - 2 && n > 4)
                {
                    Console.Write(new string(' ', n / 2 + 1));
                    Console.Write(new string('_', middleWidth));
                    Console.Write(new string(' ', n / 2 + 1));
                }
                else
                {
                    Console.Write(new string(' ', 2 * n - 2));
                }
                Console.WriteLine("|");
            }

            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            if (n > 4)
            {
                Console.Write(new string(' ', middleWidth));
            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }

    }
}
