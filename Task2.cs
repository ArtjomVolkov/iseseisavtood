using System;
using System.Collections.Generic;
using System.Text;

namespace iseseisavtood
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                a[i] = r.Next(9999);
                if (a[i] > -100 && a[i] < 100) count++;
            }
            Console.WriteLine("Count {0}", count);
        }
    }
}
