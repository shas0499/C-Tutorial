using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class Ex_ComputeNumbersinStringArray
    {
        static void Main()
        {
            string[] array = { "20.4", "39.4", "49.3", "21" };
            double sum = 0;

            foreach (string str in array)
            {
                double elm = Convert.ToDouble(str);
                sum += elm;
            }
            Console.WriteLine(sum);
        }
    }
}
