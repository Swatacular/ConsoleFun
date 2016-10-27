using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start. . .");
            Console.ReadKey();
            int answer = 0;
            for (int i = 50; i <= 10000; i++)
            {

                Console.WriteLine(i);
                answer += i;
                Console.WriteLine(answer);
            }
            Console.WriteLine();
            Console.WriteLine("Sum of every number from 50 to 10000: " + answer);
            Console.WriteLine("Avg of every number from 50 to 10000: " + answer / 9950);
            Console.ReadKey();
        }
    }
}
