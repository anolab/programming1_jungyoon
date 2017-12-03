using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacchiProject
{
    class Fibonacchi
    {
        static int[] fibonacchiList;

        public Fibonacchi()
        {
            fibonacchiList = new int[100];
        }

        public int fibonacchi(int num)
        {
            int temp1;
            int temp2;

            if (num == 0)
            {
                fibonacchiList[num] = 1;
                return 1;
            }
            if (num == 1)
            {
                fibonacchiList[num] = 1;
                return 1;
            }
            else
            {
                if (fibonacchiList[num - 1] == 0)
                    temp1 = fibonacchi(num - 1);
                else
                    temp1 = fibonacchiList[num - 1];

                if (fibonacchiList[num - 2] == 0)
                    temp2 = fibonacchi(num - 2);
                else
                    temp2 = fibonacchiList[num - 2];

                return temp1 + temp2;
            }
        }
    }
}
