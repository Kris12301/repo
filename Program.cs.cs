
change with bash
change witj kostenurka
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            var s = 1.0;
        for (int i=2;i<=n;i++)
            {
                s += (i*i)/(i-1.0);
            }
            Console.WriteLine("{0:N2}",s);
        }
    }
}
