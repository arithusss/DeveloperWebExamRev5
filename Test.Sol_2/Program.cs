using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Sol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResult(new int[] { 1, 2, 3, 4, 5 },12);
            DisplayResult(new int[] { 1, 2, 3, 4, 5 }, 15);
            DisplayResult(new int[] { 1, 2, 3, 4, 5 }, 8);
            DisplayResult(new int[] { 1, -1, 1, -1, 1 }, 0);
            DisplayResult(new int[] {}, 99);
            DisplayResult(new int[] { 3, 0, -2, 4, -6 }, -4);
        }

        static List<int> isTailSum(int[] testInput, int k)
        {
            testInput = testInput ?? new int[] {};

            int count = testInput.Count();
            List<int> nSolution = new List<int>();

            testInput = testInput.Reverse().ToArray();

            for (int i = 1; i <= count; i++)
            {
                //int sum = testInput.Take(i).Aggregate((s1, s2) => s1 + s2); //same result
                int sum = testInput.Take(i).Sum();
                if (sum == k)
                {
                    nSolution.Add(i);
                }
            }

            if (!nSolution.Any())
            {
                nSolution.Add(0);
            }

            return nSolution;
        }

        static void DisplayResult(int[] lsNumber, int k) {
            Console.WriteLine($"new int[] {{ {string.Join(", ", lsNumber)} }} : n = { string.Join(", ", isTailSum(lsNumber, k).ToArray()) }");
        }
    }
}
