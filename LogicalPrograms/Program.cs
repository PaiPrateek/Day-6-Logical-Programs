using System;
using System.Diagnostics;

namespace LogicalPrograms
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double fahre;
            
            Console.WriteLine("Press 0 to Convert Celsius to Fahrenheit Press 1 for Fahrenheit to Celsius ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    Console.WriteLine("Enter Celcius:");
                    double celsius = double.Parse(Console.ReadLine());
                    fahre = (celsius * 9/5)+ 32;
                    Console.WriteLine("Fahrenheit: " + fahre);
                    break;

                case 1:
                    Console.WriteLine("Enter Fahrenheit:");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Celcius: " + celsius);
                    break;
                    default:
                    break;
            }


            //int day = dayofweek(04, 11, 1996);

            //switch (day)
            //{
            //    case 0:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;

            //}

            //Console.Write(day);

            //StopWatch();
            //Console.WriteLine("Enter Amount for Change is needed");
            //int amount = int.Parse(Console.ReadLine());
            //countCurrency(amount);
        }
        public static void StopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.Write("Please Enter to Start the Stop Watch");
            string start = Console.ReadLine();
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

        static int dayofweek(int d, int m, int y)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };

            y -= (m < 3) ? 1 : 0;

            return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
        }


    }
}
