using System;
using System.Diagnostics;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopWatch();
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

    }
}
