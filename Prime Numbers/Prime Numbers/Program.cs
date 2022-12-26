using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, i, count, start, end;
            Console.Write("Enter First Number : ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", start, end);

            for (k = start; k <= end; k++)
            {
                count = 0;

                for (i = 2; i <= k / 2; i++)
                {
                    if (k % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && k != 1)
                    Console.Write("{0} ", k);
            }
            Console.Write("\n");
        }
    }
}
