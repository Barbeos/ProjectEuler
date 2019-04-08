using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._11_20
{
    class Problem19
    {
        public static int CountingSundays()
        {
            int result = 0;

            DateTime dateTime = new DateTime(1901, 1, 1);
            for (int year = 0; year < 100; year++)
                for (int month = 0; month < 12; month++)
                {
                    if (dateTime.ToString("dddd") == "Sunday")
                        result++;

                    dateTime = dateTime.AddMonths(1);
                }
            return result;
        }
    }
}
