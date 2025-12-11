using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class AND_OR
    {
        static void Main()
        {
            int a = -19;
            int b = 20;

            if (a > 0 && b > 0)
            {
                Console.WriteLine("Both are positive numbers");
            }
            else if (a > 0 || b > 0)
            {
                Console.WriteLine("One number is postive and another one is negetive");
            }
            else
            {
                Console.WriteLine("Both are negetive numbers");
            }
        }
    }
}
