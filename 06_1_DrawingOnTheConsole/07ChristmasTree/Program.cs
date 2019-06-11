using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string(' ', n + 1));
        Console.WriteLine("|");

        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write(new string('*', row));
            Console.Write(" | ");
            Console.WriteLine(new string('*', row));
        }
    }
}
