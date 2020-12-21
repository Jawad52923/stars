using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace star_with_decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 8; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
