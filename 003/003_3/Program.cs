using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintOneToTen();
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            //PrintNumbers(min, max);

            //int result = SumOneToTen();

            Console.WriteLine(SumMinToMax(min, max));


            Console.ReadKey();

        }

        static void PrintOneToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintNumbers(int Max)
        {
            for (int i = 1; i <= Max; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintNumbers(int Min, int Max)
        {
            for (int i = Min; i <= Max; i++)
            {
                Console.WriteLine(i);
            }
        }

        static int SumOneToTen()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            return sum;
        }
        static int SumMinToMax(int Min, int Max)
        {
            int sum = 0;
            for (int i = Min; i <= Max; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
