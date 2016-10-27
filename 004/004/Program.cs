using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {

            Sum();


            
        }

        static int Sum()
        {

            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int Sum(int max)
        {

            int sum = 0;

            for (int i = 1; i <= max; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int Sum(int min, int max)
        {

            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
