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
        public static int result, lon = 0;

        public static long Calc(int limit)
        {
            Parallel.For(1, limit, i =>
            {
                //Console.WriteLine(i);
                if (i < result || (i & 1) == 0)
                    return;
                int check = CheckNum(i);
                if (check > lon)
                {
                    result = i;
                    lon = check;
                }
            });
            //Console.WriteLine("Longest chain: " + val + " chain: " + lon);
            return result;
        }

        public static int CheckNum(long num)
        {

            int chain = 0;
            while (num > 1)
            {
                if ((num & 1) == 0)
                    num = num / 2;
                else
                    num = num * 3 + 1;
                chain++;
            }
            return chain;
        }
    }
}

