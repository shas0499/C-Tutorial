using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class Loop
    {
        static void Main()
        {
            // For Loop
            for (int i = 1; i <11; i++)
            {
                Console.WriteLine("i = "+i);
            }
            Console.WriteLine("-------------------");
            for (int i = 10; i>0; i--)
            {
                Console.WriteLine("i = " + i);
            }


            // While Loop
            Console.WriteLine("---While Loop----");
            int j = 0;

            while (j < 11)
            {
                Console.WriteLine("J = "+j);
                j++;
            }

            Console.WriteLine("---Do_While Loop----");
            int k = 10;

            do
            {
                Console.WriteLine("K = " + k);
                k++;
            } while (k < 10);

            /* Do-While checks the the while condition later
             * In while llop condition will check 1st */
        }
    }
}
