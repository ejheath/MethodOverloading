using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(2, 2);
            Add(2.0m, 3.54m);
            Console.WriteLine(Add(3, 4, true));
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isPlural)
        {
            var sum = x + y;
            if (sum == 1)
            {
                isPlural = true;
                return ($"{sum} + dollar");
            }
            else
            {
                return ($"{sum} dollars");
            }

        }

    }
}
