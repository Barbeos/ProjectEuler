﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fifth._1_10;
using fifth._11_20;
using fifth._21_30;

namespace fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Problem1.MultiplesOf3And5());
            //Console.WriteLine(Problem2.EvenFibonacciNumbers());
            //Console.WriteLine(Problem3.LargestPrimeFactor());
            //Console.WriteLine(Problem4.LargestPalindromeProduct());
            //Console.WriteLine(Problem5.SmallestMultiple());
            //Console.WriteLine(Problem6.SumSquareDifference());
            //Console.WriteLine(Problem7.ThousandAndOnePrime());
            //Console.WriteLine(Problem8.LargestProductInAeries());
            //Console.WriteLine(Problem9.SpecialPythagoreanTriplet());
            //Console.WriteLine(Problem10.SummationOfPrimes());
            //Console.WriteLine(Problem11.LargestProductInAGrid());
            //Console.WriteLine(Problem12.HighlyDivisibleTriangularNumber());
            //Console.WriteLine(Problem13.LargeSum());




            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            for (int i = 0; i< 1; i++)
            { 
                Console.WriteLine(Problem14.Calc(1000000));
            }


            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            //Console.WriteLine(Problem15.LatticePaths());
            //Console.WriteLine(Problem16.SumOfNumber());
            //Console.WriteLine(Problem17.NumberLetterCounts());
            //Console.WriteLine(Problem18.MaximumPathSumI());
            //Console.WriteLine(Problem19.CountingSundays());
            //Console.WriteLine(Problem20.FactorialDigitSum());

            //Console.WriteLine(Problem21.AmicableNumbers());




            Console.ReadKey();
        }
    }
}
