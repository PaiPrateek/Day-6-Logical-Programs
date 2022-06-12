using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerfectNumber();
        }
        public static void PerfectNumber()
        {
            int i, n, sum;
            int min, max;

            Console.WriteLine("Find the Perfect number within a given number of range ");

            Console.WriteLine("Enter the Lower Limit");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Upper Limit");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Perfect Number within the given Range is :");

            {
                for (n = min; n < max; n++)
                {
                    i = 1;
                    sum = 0;

                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.WriteLine("{0}", n);
                }
            }
        }
    }
}
