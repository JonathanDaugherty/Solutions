using System;

namespace Solutions
{
    class Program
    {
        static int getMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
                total -= a[i];

            return total;
        }
        public static void Main()
        {
            int[] a = { 1, 2, 3, 5 };
            int miss = getMissingNo(a, 4);
            Console.WriteLine($"The missing number is {miss}");

            int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            int miss2 = getMissingNo(b, 9);
            Console.WriteLine($"The missing number is {miss2}");

            int[] c = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int miss3 = getMissingNo(c, 11);
            Console.WriteLine($"The missing number is {miss3}");
        }
    }
}
