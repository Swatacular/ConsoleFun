using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lotsO_Numbers = { 1, 4, 3, 5, 7, 6, 9, 8, 10, 2 };
            int lowestNumber = lotsO_Numbers[0];
            int highestNumber = lotsO_Numbers[0];

            for (int i = 1; i < lotsO_Numbers.Length; i++)
            {
                //checks if the last lowest number was 
                if (lowestNumber > lotsO_Numbers[i]) lowestNumber = lotsO_Numbers[i];

                if (highestNumber < lotsO_Numbers[i]) highestNumber = lotsO_Numbers[i];
            }
            foreach (int i in lotsO_Numbers)
            {
                //checks if the last lowest number was 
                if (lowestNumber > lotsO_Numbers[i]) lowestNumber = lotsO_Numbers[i];

                if (highestNumber < lotsO_Numbers[i]) highestNumber = lotsO_Numbers[i];
            }
            Console.WriteLine("The lowest number is: " + lowestNumber);

            Console.WriteLine("The highest number is: " + highestNumber);

            Console.ReadKey();
        }
    }
}
