using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                Console.WriteLine(new string('*', n));
            }

            //option 2
            //int num = int.Parse(Console.ReadLine());

            //for (int rows = 0; rows < num; rows++)
            //{
            //    for (int cols = 0; cols < num; cols++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
