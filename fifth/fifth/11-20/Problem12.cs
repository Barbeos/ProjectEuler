using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._11_20
{
    class Problem12
    {
        public static long HighlyDivisibleTriangularNumber()
        {
            long count = 1;
            long iterator = 0;
            long triangleNumber = 0;
            while (true)
            {
                count += 1;
                triangleNumber = (count * (count + 1)) / 2;

                if (triangleNumber % 2 == 0){ }
                else
                    continue;
                
                int length = (int)Math.Sqrt(triangleNumber);
                for (long i = 1; i <= length; i++)
                {
                    if (triangleNumber % i == 0)
                    {
                        iterator += 2;                        
                    }                        
                }
                iterator++;
                if (iterator > 500)
                    break;
                iterator = 0;
            }
            return triangleNumber;
        }
    }
}
