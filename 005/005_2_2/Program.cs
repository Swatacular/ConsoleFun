using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string str2 = string.Concat("Hello", " World!");

            Console.WriteLine(str2);

            string[] str = { "Hello World! Nice to meet you... ?", "Hi again" };

            long numberOfDifferentStringsInArray = str.LongCount();
            Console.WriteLine(str.LongCount());


            string input = Console.ReadLine();

            int cut = int.Parse(Console.ReadLine());
            Console.WriteLine(input.ToCharArray(cut, (input.ToCharArray().Count() - cut)));
            Console.WriteLine(input.ToCharArray(cut, (input.Substring(cut)).Length));
            //LENGTH is not a function

            for (int i = 0; i < input.ToCharArray().Count(); i++)
            {
                Console.WriteLine((input.ToCharArray()).ElementAt(i));
            }

            //Console.Write(input.IndexOf("e"));
            //Console.WriteLine(input.LastIndexOf("e"));
            Console.ReadKey();


        }
    }
}
