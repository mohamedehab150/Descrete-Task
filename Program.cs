using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الاعداد_الاولية
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter start and end");
            int NUM1 = int.Parse(Console.ReadLine());
            int NUM2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = NUM1; i <= NUM2; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
            }
        }
    }
}
