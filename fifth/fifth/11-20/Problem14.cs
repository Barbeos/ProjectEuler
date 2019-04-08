using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace fifth._11_20
{
    class Problem14
    {
        internal static BigInteger LongestCollatzSequence()
        {
            BigInteger result = new BigInteger(0); ;
            BigInteger count = new BigInteger(1);
            BigInteger n = new BigInteger(0);
            BigInteger temp = new BigInteger(1);

            for (BigInteger i = 2; i < 1000000; i++)
            {
                n = i;
                while (true)
                {
                    if (n.IsEven)
                        n = BigInteger.Divide(n, 2);
                    else
                        n = BigInteger.Add(BigInteger.Multiply(n, 3),1);
                    
                    count++;

                    if (BigInteger.Compare(n, 1) == 0)
                        break;                        
                }
                if (count > temp)
                {
                    result = i;
                    temp = count;
                }
                    
                count = 1;
            }
            return result;
        }
    }
}
