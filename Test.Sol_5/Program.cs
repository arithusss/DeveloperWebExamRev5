using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Sol_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResult(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            DisplayResult(new int[] { 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 });
            DisplayResult(new int[] { 4, 1, 2, 3 });
            DisplayResult(new int[] { 97, 4, 1, 2, 3, 99, 102, 120, 2, 13, 1, 120, 113 });
        }

        static List<int> top3EvenNumber(int[] testInput)
        {
            return testInput.Where(t => (t % 2) == 0).OrderByDescending(t=>t).Take(3).ToList();
        }

        static void DisplayResult(int[] lsNumber)
        {
            Console.WriteLine($"new int[] {{ {string.Join(", ", lsNumber)} }} : Answer = { string.Join(", ", top3EvenNumber(lsNumber).ToArray()) }");
        }
    }
}
