using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1B_Compute_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeSumTriple(1, 2));
            Console.WriteLine(ComputeSumTriple(3,2));
            Console.WriteLine(ComputeSumTriple(2,2));

            Console.ReadLine();
        }
        // program to compute the sum of the two numerical values.
        // If the two values are the same, return triple their sum.

        public static int ComputeSumTriple(int num1, int num2)
        {
            if (num1 == num2)
            {
              int  TripleSum=(num1 + num2) * 3;
                return TripleSum;
            }
            else
            {
               int sum= num1 + num2;
                return sum;

            }
        }
    }
}
