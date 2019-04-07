using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem3
    {
        public static int LargestPrimeFactor()
        {
            int result = 0;
            long number = 600851475143;

            for(long i = (long)Math.Ceiling(Math.Sqrt(number)); i > 0; i -= 2)
            {
                if (number % i == 0)
                    if (IsPrime(i))
                        return (int)i;                        
            }
            return result;
        }

        public static bool IsPrime(long factor)
        {
            if (factor <= 1) return false;
            if (factor == 2) return true;
            if (factor % 2 == 0) return false;

            long boundary = (long)Math.Floor(Math.Sqrt(factor));

            for (long i = 3; i <= boundary; i += 2)
                if (factor % i == 0)
                    return false;

            return true;
        }
    }
}
