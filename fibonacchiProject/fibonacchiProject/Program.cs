using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacchiProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Fibonacchi f1 = new Fibonacchi();
            Console.WriteLine(f1.fibonacchi(num)); 
        }
     }
}
