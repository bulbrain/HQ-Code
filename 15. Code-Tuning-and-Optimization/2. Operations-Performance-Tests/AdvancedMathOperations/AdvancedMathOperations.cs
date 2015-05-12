using System;
using System.Diagnostics;

namespace AdvancedMathOperations
{
    internal class AdvancedMathOperations
    {
        private static void DisplayExecutionTime(Action action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static void Main(string[] args)
        {
            float floatNum = 10;
            float floatResult = 0;
            double doubleNum = 10;
            double doubleResult = 0;
            decimal decimalNum = 1;
            decimal decimalResult = 0;

            Console.Write("Square float:\t");
            DisplayExecutionTime(() => { floatResult = (float) Math.Sqrt(floatNum); });
            Console.Write("Log float:\t");
            DisplayExecutionTime(() => { floatResult = (float) Math.Log(floatNum); });
            Console.Write("Sinus float:\t");
            DisplayExecutionTime(() => { floatResult = (float) Math.Sin(floatNum); });
            Console.WriteLine();

            Console.Write("Square double:\t");
            DisplayExecutionTime(() => { doubleResult = Math.Sqrt(doubleNum); });
            Console.Write("Log double:\t");
            DisplayExecutionTime(() => { doubleResult = Math.Log(doubleNum); });
            Console.Write("Sinus double:\t");
            DisplayExecutionTime(() => { doubleResult = Math.Sin(doubleNum); });
            Console.WriteLine();

            Console.Write("Square decimal:\t");
            DisplayExecutionTime(() => { decimalResult = (decimal) Math.Sqrt((double) decimalNum); });
            Console.Write("Log decimal:\t");
            DisplayExecutionTime(() => { decimalResult = (decimal) Math.Log((double) decimalNum); });
            Console.Write("Sinus decimal:\t");
            DisplayExecutionTime(() => { decimalResult = (decimal) Math.Sin((double) decimalNum); });
            Console.ReadLine();
        }
    }
}