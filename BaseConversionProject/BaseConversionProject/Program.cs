using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConversionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            BaseConversion(num);

        }
        static void BaseConversion(int num)
        {
            if (num == 0)
            {
                Console.Write(0);
                return;
            }
            else if(num == 1)
            {
                Console.Write(1);
                return;
            }
            Console.Write(num % 2);
            BaseConversion(num / 2);

        }
    }
}
