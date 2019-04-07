using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem6
    {
        internal static int SumSquareDifference()
        {
            int powOfNumbers = 0;
            int sumOfNumbers = 0;
            for(int i = 1; i <= 100; i++)
            {
                powOfNumbers += (int)Math.Pow(i, 2);
                sumOfNumbers += i;
            }

            int result = (int)Math.Pow(sumOfNumbers, 2) - powOfNumbers;

            return result;
        }
    }
}
