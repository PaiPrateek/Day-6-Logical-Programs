using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciSeries();
        }
        public static void FibonacciSeries()
        {
            int X1=0, X2=1, X3=1, Number;
            Console.WriteLine("Enter Eny Number");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fibonacci Series For the entered Number is:");
            Console.WriteLine("...........................");
            Console.Write(X1 + " " + X2 + " ");
            for(int i=2; i < Number;i++)
            {
                X3 = X1 + X2;
                Console.Write(X3 + " ");
                X1 = X2;
                X2 = X3;
            }


        }

    }
}
