using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class Condition
    {
        static void Main()
        {
            int x = 30;
            int y = 40;

            if (x > y)
            {
                Console.WriteLine($"{x} is greter than {y}");
            }
            else if (y > x)
            {
                Console.WriteLine($"{y} is greater than {x}");
            }
            else
            {
                Console.WriteLine("Both number is equal");
            }
        }
    }
}
