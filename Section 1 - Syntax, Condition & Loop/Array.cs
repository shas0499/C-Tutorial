using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Basic_of_C_
{
    internal class Array
    {
        static void Main()
        {
            // Declare an Array
            int[] a = { 10, 20, 30, 40, 50, 60 };

            // Retrive perticular position value
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);

            // Retrive all elements with for loop
            Console.WriteLine("----For Loop---------");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            // Retrive all elements with foreach loop
            Console.WriteLine("----ForEach Loop---------");

            foreach(int temp in a) {  Console.WriteLine(temp); }

            // Initialize an array and then assign value

            Console.WriteLine("Initialize an array..........");

            int[] arr = new int[6];
            arr[2] = 30;
            arr[5] = 60;

            foreach(int tempvar in arr) { Console.WriteLine(tempvar); }

        }
    }
}
