using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 8; ++row)
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
