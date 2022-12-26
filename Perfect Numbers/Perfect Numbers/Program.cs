using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, i, start, end, sum;
            Console.Write("Enter First Number : ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers are : ");
            for (k = start; k <= end; k++)
            {
                i = 1;
                sum = 0;
                while (i < k)
                {
                    if (k % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == k)
                    Console.Write("{0} ", k);
            }
            Console.Write("\n");
        }
    }
}
