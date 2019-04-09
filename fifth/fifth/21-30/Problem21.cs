using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._21_30
{
    class Problem21
    {
        public static int AmicableNumbers()
        {
            int result = 0;
            //List<Friends> friends = new List<Friends>();

            //for(int i = 0; i < 10000; i++)
            //{
            //    int friendOne = SumOfDivisors(i);
            //    int friendTwo = SumOfDivisors(friendOne);
            //    int temp = SumOfDivisors(friendTwo);

            //    if (friendTwo == i && temp == friendOne) ;


            //}



            return result;
        }

        private static int SumOfDivisors(int i)
        {
            int sum = 0;
            for(int j = 1; j < Math.Ceiling(Math.Sqrt(i)); i++)
            {
                if (i % j == 0)
                    sum += j;
            }
            return sum;
        }
    }

    internal class Friends
    {
        
    }
}
