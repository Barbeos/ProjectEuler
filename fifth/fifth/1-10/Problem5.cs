using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem5
    {
        public static int SmallestMultiple()
        {
            int counter = 20;
            int temp = 0;
            while (true)
            {
                
                for(int i = 1; i < 21; i++)
                {
                    if (counter % i == 0)
                    {
                        temp++;
                        continue;
                    }                        
                }
                if (temp == 20)
                {                   
                    break;
                } 
                temp = 0;
                counter += 20;
            }
            return counter;
        }
    }
}
