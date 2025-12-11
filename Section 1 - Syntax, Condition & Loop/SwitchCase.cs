using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class SwitchCase
    {
        static void Main()
        {
            string str = "Three";

            switch (str)
            {
                case "Zero":
                    Console.WriteLine(str);
                    break;

                case "One":
                    Console.WriteLine(str);
                    break;

                case "Two":
                    Console.WriteLine(str);
                    break;

                default:
                    Console.WriteLine("Value Not Found!!!");
                    break;
            }
        }
    }
}
