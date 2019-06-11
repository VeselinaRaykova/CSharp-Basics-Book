using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                if (rows == 1 || rows == n)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }

                for (int cols = 1; cols <= n - 2; cols++)
                {
                    Console.Write(" -");
                }

                if (rows == 1 || rows == n)
                {
                    Console.WriteLine(" +");
                }
                else
                {
                    Console.WriteLine(" |");
                }

            }
        }
    }
}
