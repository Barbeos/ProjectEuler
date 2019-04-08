using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace fifth._11_20
{
    class Problem18
    {
        public static int MaximumPathSumI()
        {
            int[,] triangle = FileReader();

            int lines = triangle.GetLength(0);

            for (int y = lines - 2; y >= 0; y--)
                for (int x = 0; x <= y; x++)
                    triangle[y, x] += Math.Max(triangle[y + 1, x], triangle[y + 1, x + 1]);

            return triangle[0, 0];
        }

        private static int[,] FileReader()
        {
            string[] lineNumbers = new string[40];

            string[] lines = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"triangle.txt"), Encoding.UTF8);

            int[,] triangle = new int[lines.Length, lines.Length];

            int k = 0;
            foreach (string line in lines)
            {
                lineNumbers = line.Split(' ');
                for (int i = 0; i < lineNumbers.Length; i++)
                    triangle[k, i] = int.Parse(lineNumbers[i]);
                k++;
            }
            return triangle;
        }
    }
}
