using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الأعداد_المثالية
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Console.WriteLine("Please enter NUM1 and NUM2");
            long NUM1 = long.Parse(Console.ReadLine());
            long NUM2 = long.Parse(Console.ReadLine());
            long SUM = 0;
            for (long i = NUM1; i <= NUM2; i++)
            {
                for (long x = 1; x < i; x++)
                {
                    if (i % x == 0)
                        SUM += x;
                }
                if (SUM == i)
                    Console.WriteLine(i);
                SUM = 0;
            }
            Console.ReadKey();

        }
    }
}
