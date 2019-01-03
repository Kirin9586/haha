using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0,sum=0;
            Console.Write("Input n:");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
                sum = sum + i;
            Console.Write("Tong {0}\n", sum);
            Console.ReadKey();
        }
    }
}
