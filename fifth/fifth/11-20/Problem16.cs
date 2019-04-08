using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace fifth._11_20
{
    class Problem16
    {
        public static BigInteger SumOfNumber()
        {
            int result = 0;
            foreach (char s in PowOfFifteen().ToCharArray()) {
                
                result += (int)Char.GetNumericValue(s);
            }            
            return result;
        }

        private static String PowOfFifteen()
        {
            return BigInteger.Pow(2, 1000).ToString();
        }
    }
}
