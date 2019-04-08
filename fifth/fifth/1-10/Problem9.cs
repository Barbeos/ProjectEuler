using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem9
    {
        public static int SpecialPythagoreanTriplet()
        {
            int result = 0;
            int c = 0;
            int s = 1000;

            for (int a = s; 0 < a; a--)
                for (int b = s; 0 < b; b--)
                    if (a < b)
                    {
                        c = a * a + b * b;
                        if (Math.Sqrt(c) % 1 == 0 && b < Math.Sqrt(c) && a + b + (int)Math.Sqrt(c) == s)
                            result = a * b * (int)Math.Sqrt(c);
                    }
                    else
                        break;

            return result;
        }
    }
}
