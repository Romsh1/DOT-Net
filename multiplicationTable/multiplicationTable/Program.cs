using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horzStart, horzEnd;
            int vertStart, vertEnd;

            /* (11, 13) */
            horzStart = 11;
            horzEnd = 13;

           /* ( 3, 6) */
            vertStart = 3;
            vertEnd = 6;

            Console.Write("{0, -4", "X");

            for(int col = horzStart; col <= horzEnd; col++)
            {
                Console.Write("{0, -4", col);
            }
            Console.WriteLine();

            for (int row = vertStart; row <= vertEnd; row++)
            {
                Console.Write("{0, -4}", row);
                for(int col = horzStart; col <= horzEnd ; col++)
                {
                    Console.Write("{0, -4}", row * col);
                }
                Console.WriteLine() ;
            }
        }
    }
}
