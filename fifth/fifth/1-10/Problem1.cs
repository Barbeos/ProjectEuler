using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem1
    {
        public static int MultiplesOf3And5()
        {
            int result = 0;

            for(int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
            return result;
        }
    }
}
