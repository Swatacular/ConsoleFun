using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amethodthatdoesstuff();
            Console.ReadKey();
        }

        private static void Amethodthatdoesstuff()
        {
            int[] array1 = new int[10];

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                sum += array2[i];
                Console.WriteLine(array2[i]);
            }

            for (int i = array2.Length - 1; i >= 0; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine(array2[2]);
            Console.WriteLine(array1[20]);
        }
    }
}
