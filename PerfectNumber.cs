using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class PerfectNumber
    {
        public void Number()
        {
            int sum = 0;
            Console.Write("Please enter the Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    sum += i;
                    Console.WriteLine("{0} ", i);
                }
            }
            if (sum == Number)
            {
                Console.WriteLine(Number + " is a Perfect number");
            }
            else
            {
                Console.WriteLine(Number + " is not a Perfect number");
            }
        }
    }
}
