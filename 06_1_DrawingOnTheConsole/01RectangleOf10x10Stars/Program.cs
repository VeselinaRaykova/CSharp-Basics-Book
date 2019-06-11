using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
