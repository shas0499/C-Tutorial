using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class Ex_PrintLowerCase
    {
        static void Main()
        {
            string str = "HELLO WORLD";

            string str1 = str.Substring(6);
            Console.WriteLine(str1.ToLower());
        }
    }
}
