using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class Ex_Calculate_Tax
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Salary - ");
            string input = Console.ReadLine();

            double salary = Convert.ToDouble(input);

            if (salary <= 8350)
            {
                double Tax = salary*0.1;
                salary = salary - Tax;
                Console.WriteLine("Salary after Tax deduction : " + salary);
            }
            else if (salary > 8350 && salary <= 33950)
            {
                double Tax1 = salary * 0.15;
                salary = salary - Tax1;
                Console.WriteLine("Salary after Tax deduction : " + salary);
            }
            else if (salary > 33950){
                double Tax2 = salary * 0.25;
                salary = salary - Tax2;
                Console.WriteLine("Salary after Tax deduction : " + salary);
            }
        }
    }
}
