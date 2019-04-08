using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth._11_20
{
    class Problem17
    {
        public static int NumberLetterCounts()
        {
            String[] ones = new String[] {
                            "one", "two", "three",
                            "four", "five", "six",
                            "seven", "eight","nine" };
            String[] teens = new String[] {
                           "ten", "eleven", "twelve", "thirteen",
                           "fourteen", "fifteen", "sixteen",
                           "seventeen", "eighteen", "nineteen" };
            String[] tens = new String[] {
                           "twenty", "thirty", "forty", "fifty",
                           "sixty", "seventy", "eighty", "ninety" };

            int result = 0;

            int sumOfOnes = NumberLengths(ones);

            int sumOfTeens = NumberLengths(teens);

            int sumOfTens = NumberLengthsTens(tens, sumOfOnes);

            result = sumOfOnes + sumOfTeens + sumOfTens;

            result += NumberLengthsHundreds(ones, result) + "onethousand".Length;

            return result;
        }

        // ones and teens
        private static int NumberLengths(String[] numberLength)
        {
            int sum = 0;
            for (int i = 0; i < numberLength.Length; i++)
                sum += numberLength[i].Length;
            return sum;
        }

        // tens
        private static int NumberLengthsTens(String[] numberLength, int sumOfOnes)
        {
            int sum = 0;
            for (int i = 0; i < numberLength.Length; i++)
                sum += numberLength[i].Length * 10 + sumOfOnes;
            return sum;
        }

        private static int NumberLengthsHundreds(String[] numberLength, int sum)
        {
            int hundredsSum = 0;
            for (int i = 0; i < numberLength.Length; i++)
                hundredsSum += (numberLength[i] + "hundredand").Length * 100 + sum - 3;
            return hundredsSum;
        }
    }
}
