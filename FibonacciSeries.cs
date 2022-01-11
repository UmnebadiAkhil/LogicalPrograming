using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class FibonacciSeries
    {
        public void Series()
        {
            var fibonacciNumbers = new List<long> { 1, 1 };
            Console.Write("Please enter the nth Numbers : ");
            long n = Convert.ToInt64(Console.ReadLine());
            while (fibonacciNumbers.Count < n)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);

            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}
