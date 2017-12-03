using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlgorithmProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GCD(num1, num2));
        }

        static int GCD(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            return GCD(num2, num1 % num2);
        }

        
    }
}
