using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem2
    {
        public static List<int> fibonachi = new List<int>();

        internal static int EvenFibonacciNumbers()
        {
            int result = 0;
            fibonachi.Add(1);
            int temp = 0;

            while (fibonachi[fibonachi.Count - 1] < 4000000)
            {
                if ((temp = FibonachiCalc()) % 2 == 0) {
                    result += temp;
                }
            }           
            return result;
        }

        public static int FibonachiCalc()
        {           
            if(fibonachi.Count > 1)
            {
                fibonachi.Add(fibonachi[fibonachi.Count - 1] + fibonachi[fibonachi.Count - 2]);
            }else if(fibonachi.Count == 1){
                fibonachi.Add(1);
            }

            return fibonachi[fibonachi.Count - 1];
        }
    }
}
