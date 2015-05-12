using System;
using System.Diagnostics;

namespace _2.Operations_Performance_Tests
{
    internal class MathOperations
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
            var intNum = 1;
            var intResult = 0;
            long longNum = 1;
            long longResult = 0;
            float floatNum = 1;
            float floatResult = 0;
            double doubleNum = 1;
            double doubleResult = 0;
            decimal decimalNum = 1;
            decimal decimalResult = 0;

            Console.Write("Add int:\t");
            DisplayExecutionTime(() => { intResult = intNum + intNum; });
            Console.Write("Subst int:\t");
            DisplayExecutionTime(() => { intResult = intNum - intNum; });
            Console.Write("Incre int:\t");
            DisplayExecutionTime(() => { intResult = intNum++; });
            Console.Write("Multy int:\t");
            DisplayExecutionTime(() => { intResult = intNum*intNum; });
            Console.Write("Divid int:\t");
            DisplayExecutionTime(() => { intResult = intNum/intNum; });
            Console.WriteLine();

            Console.Write("Add long:\t");
            DisplayExecutionTime(() => { longResult = longNum + longNum; });
            Console.Write("Subst long:\t");
            DisplayExecutionTime(() => { longResult = longNum - longNum; });
            Console.Write("Incre long:\t");
            DisplayExecutionTime(() => { longResult = longNum++; });
            Console.Write("Multy long:\t");
            DisplayExecutionTime(() => { longResult = longNum*longNum; });
            Console.Write("Divid long:\t");
            DisplayExecutionTime(() => { longResult = longNum/longNum; });
            Console.WriteLine();

            Console.Write("Add float:\t");
            DisplayExecutionTime(() => { floatResult = floatNum + floatNum; });
            Console.Write("Subst float:\t");
            DisplayExecutionTime(() => { floatResult = floatNum - floatNum; });
            Console.Write("Incre float:\t");
            DisplayExecutionTime(() => { floatResult = floatNum++; });
            Console.Write("Multy float:\t");
            DisplayExecutionTime(() => { floatResult = floatNum*floatNum; });
            Console.Write("Divid float:\t");
            DisplayExecutionTime(() => { floatResult = floatNum/floatNum; });
            Console.WriteLine();

            Console.Write("Add double:\t");
            DisplayExecutionTime(() => { doubleResult = doubleNum + doubleNum; });
            Console.Write("Subst double:\t");
            DisplayExecutionTime(() => { doubleResult = doubleNum - doubleNum; });
            Console.Write("Incre double:\t");
            DisplayExecutionTime(() => { doubleResult = doubleNum++; });
            Console.Write("Multy double:\t");
            DisplayExecutionTime(() => { doubleResult = doubleNum*doubleNum; });
            Console.Write("Divid double:\t");
            DisplayExecutionTime(() => { doubleResult = doubleNum/doubleNum; });
            Console.WriteLine();

            Console.Write("Add decimal:\t");
            DisplayExecutionTime(() => { decimalResult = decimalNum + decimalNum; });
            Console.Write("Subst decimal:\t");
            DisplayExecutionTime(() => { decimalResult = decimalNum - decimalNum; });
            Console.Write("Incre decimal:\t");
            DisplayExecutionTime(() => { decimalResult = decimalNum++; });
            Console.Write("Multy decimal:\t");
            DisplayExecutionTime(() => { decimalResult = decimalNum*decimalNum; });
            Console.Write("Divid decimal:\t");
            DisplayExecutionTime(() => { decimalResult = decimalNum/decimalNum; });
            Console.ReadLine();
        }
    }
}