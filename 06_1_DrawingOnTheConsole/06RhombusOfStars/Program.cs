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

        //top diamond + middle row (n*n)
        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
            //Console.WriteLine(new string(' ', n - row));
        }

        //bottom part (n-1) * n 
        for (int row = 1; row <= n - 1; row++)
        {
            Console.Write(new string(' ', row));
            Console.Write("*");
            for (int col = 1; col < n - row; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
            //Console.WriteLine(new string(' ', n));
        }
    }

}

