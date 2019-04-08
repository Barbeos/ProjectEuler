using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._11_20
{
    class Problem15
    {
        public static long LatticePaths()
        {
            long result = 1;

            int gridSize = 20;

            for(int i = 0; i < gridSize; i++)
            {
                result = result * ((2 * gridSize) - i);
                result = result / (i + 1);
            }
            return result;
        }
    }
}
