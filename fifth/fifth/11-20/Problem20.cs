using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace fifth._11_20
{
    class Problem20
    {
        public static int FactorialDigitSum()
        {
            int result = 0;
            BigInteger temp = new BigInteger(1);

            for (int i = 1; i <= 100; i++)
                temp = BigInteger.Multiply(temp, i);

            foreach (char c in temp.ToString().ToCharArray())
                result += c - '0';
            return result;
        }
    }
}
