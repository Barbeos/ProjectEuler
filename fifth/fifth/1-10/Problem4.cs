using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._1_10
{
    class Problem4
    {
        public static int LargestPalindromeProduct()
        {
            int result = 0;
            List<int> palindromes = new List<int>();

            for(int i = 999; 99 < i; i--)
                for (int j = 999; 99 < j; j--)
                {
                    result = i * j;
                    if (IsPalindrome(result))
                        palindromes.Add(result);
                }
                    return palindromes.Max();
        }

        private static bool IsPalindrome(int result)
        {
            string s = result.ToString();
            string temp = "";

            for(int i = s.Length - 1; 0 <= i; i--)
                temp = temp + s.ElementAt(i);
            
            if (temp == s)
                return true;
            else
                return false;
        }
    }
}
