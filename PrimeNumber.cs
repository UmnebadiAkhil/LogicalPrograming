﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.Write("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is a Prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime number");
            }
        }
    }
}
