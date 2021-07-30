using System;
using System.Linq;

namespace Test.Sol_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResult(new int[] { 1, 2, 1, 2, 3, 3 });
            DisplayResult(new int[] { 1, 8, 1, 8, 8, 4, 4 });
            DisplayResult(new int[] { 7, -1, 7, 8, -13, -13, 8 });
            DisplayResult(new int[] { 1 });
            DisplayResult(new int[] {  });
        }

        static string isDoubleArray(int[] lsNumber)
        {

            lsNumber = lsNumber ?? new int[] { };

            if (lsNumber.Count() < 2)
            {
                return "N";
            }

            var results = lsNumber.GroupBy(t => t).Select(t => new {
                number = t.Key,
                count = t.Count()
            }).Any(t => (t.count % 2) == 1);

            return !results ? "Y" : "N";
        }

        static void DisplayResult(int[] lsNumber)
        {
            Console.WriteLine($"new int[] {{ {string.Join(", ", lsNumber)} }} : Answer = { isDoubleArray(lsNumber) }");
        }
    }
}
