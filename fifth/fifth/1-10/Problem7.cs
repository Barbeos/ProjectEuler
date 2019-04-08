using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem7
    {
        public static long ThousandAndOnePrime()
        {
            int result = 0;
            int count = 0;
            int numberOfPrimes = 0;
            while (true)
            {
                if (Problem3.IsPrime(count))
                    numberOfPrimes++;
                result = count;
                count++;
                
                if (numberOfPrimes == 10001)
                    break;
            }
            return result;
        }
    }
}
