using System;
using System.Diagnostics;

namespace LogicalPrograms
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //StopWatch();
            Console.WriteLine("Enter Amount for Change is needed");
            int amount = int.Parse(Console.ReadLine());
            countCurrency(amount);
        }
        public static void StopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.Write("Please Enter to Start the Stop Watch");
            string start= Console.ReadLine();
            stopwatch.Start();
            Console.WriteLine("....................");
            Console.Write("Please Enter to Stop the Stop Watch");
            string stop = Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine("....................");
            Console.WriteLine("Time Elapaed {0}", stopwatch.Elapsed);
        }
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 1000, 500, 200, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[9];

            // count notes 
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }

            // Print notes
            Console.WriteLine("Currency Count -");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                        + noteCounter[i]);
                }
            }
        }


    }
}
