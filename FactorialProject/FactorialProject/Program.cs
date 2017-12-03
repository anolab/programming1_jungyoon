using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int output = factorial(num);
            Console.WriteLine(num + "! = " + output);
        }

        public static int factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return factorial(num - 1) * num;
        }
    }
}


/* Factorial 정의: n! = n * (n-1) * ... * 1 이다. */