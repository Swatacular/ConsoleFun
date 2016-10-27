using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(10));
            Console.ReadKey();
        }


        //Very simple recursion, instead of using a for loop, to get factorial

        static int Fact(int x)
        {
            if (x == 1) return 1;
            x *= Fact(x - 1);
            return x;
        }
    }
}
