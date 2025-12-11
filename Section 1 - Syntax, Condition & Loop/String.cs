using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class String
    {
        static void Main()
        {
            string name = "Shaswata Barua";

            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Substring(2));
            Console.WriteLine(name.Substring(3, 4));    // Will substring the string from 3 and take 4 characters
            Console.WriteLine(name[3]);
            Console.WriteLine(name.IndexOf("B"));


            // String Array
            string[] city = { "Kolkata", "Bangalore", "Pune" };

            foreach (string s in city) { Console.WriteLine(s); }

            // String Conversion
            string age = "26";
            string salary = "60008942.78";

            int age1 = Convert.ToInt32(age);
            double salary1 = Convert.ToDouble(salary);

            Console.WriteLine(age1);
            Console.WriteLine(salary1);
        }
    }
}
