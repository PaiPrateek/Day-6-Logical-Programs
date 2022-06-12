using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber();
        }
        public static void PrimeNumber()
        {
            int n, i, m = 0, p = 0;

            Console.Write("Enter the Number to check Prime: ");
            n = Convert.ToInt32(Console.ReadLine());

            m = n / 2;

            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime Number.");
                    p = 1;
                    break;
                }
            }
            if (p == 0)

                Console.Write("Number is Prime Number.");
        }

    }
}
