using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.Write("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int revNum = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The Reverse num is : " + revNum);
        }
    }
}
