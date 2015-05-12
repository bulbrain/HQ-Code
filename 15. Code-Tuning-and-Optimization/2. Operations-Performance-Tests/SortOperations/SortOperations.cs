using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOperations
{
    class SortOperations
    {
        private static void DisplayExecutionTime(Action action)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void InsertionSort(IComparable[] dataSet)
        {
            IComparable temp;
            int j;
            for (int i = 1; i < dataSet.Length; i++)
            {
                temp = dataSet[i];
                j = i - 1;

                while (j >= 0 && dataSet[j].CompareTo(temp) > 0)
                {
                    dataSet[j + 1] = dataSet[j];
                    j--;
                }

                dataSet[j + 1] = temp;
            }
        }

        public static void SelectSort(IComparable[] dataSet)
        {
            int i,j;
            for(i = 0; i < dataSet.Length; i++)
            {
                int min=i;
                for (j = i + 1; j < dataSet.Length; j++)
                {
                    if (dataSet[j].CompareTo(dataSet[min]) < 0) min = j;
                    IComparable temp = dataSet[i];
                    dataSet[i] = dataSet[min];
                    dataSet[min] = temp;
                }
           }
        }

        public static void QuickSort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }
        
        static void Main(string[] args)
        {
            IComparable[] unsortedInt = { 121, 23, 23, 454, 21 };
            IComparable[] unsortedDouble = { 121.22, 23.12, 23.22, 454.11, 23.24 };
            IComparable[] unsortedStrings = { "z", "e", "x", "c", "m", "q", "a" };

            Console.Write("Insert sort Int:\t");
            DisplayExecutionTime(() => { InsertionSort(unsortedInt); });
            Console.Write("Select sort Int:\t");
            DisplayExecutionTime(() => { SelectSort(unsortedInt); });
            Console.Write("Quick  sort Int:\t");
            DisplayExecutionTime(() => { QuickSort(unsortedInt, 0, unsortedInt.Length - 1); });
            Console.WriteLine();

            Console.Write("Insert sort Double:\t");
            DisplayExecutionTime(() => { InsertionSort(unsortedDouble); });
            Console.Write("Select sort Double:\t");
            DisplayExecutionTime(() => { SelectSort(unsortedDouble); });
            Console.Write("Quick sort Double:\t");
            DisplayExecutionTime(() => { QuickSort(unsortedDouble, 0, unsortedDouble.Length - 1); });
            Console.WriteLine();

            Console.Write("Insert sort String:\t");
            DisplayExecutionTime(() => { InsertionSort(unsortedStrings); });
            Console.Write("Select sort String:\t");
            DisplayExecutionTime(() => { SelectSort(unsortedStrings); });
            Console.Write("Quick sort String:\t");
            DisplayExecutionTime(() => { QuickSort(unsortedStrings, 0, unsortedStrings.Length - 1); });
            Console.ReadLine();
        }
    }
}
