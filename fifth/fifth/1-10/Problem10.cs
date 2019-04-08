using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem10
    {
        public static long SummationOfPrimes()
        {
            long result = 0;
            for (int i = 0; i < 2000000; i++)
                if (Problem3.IsPrime(i))
                    result += i;

            return result;
        }
    }
}
