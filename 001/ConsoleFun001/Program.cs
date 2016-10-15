using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFun001
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> inputList = new List<char>();
            for (int i = 0; i < (input.Count<char>()); i++)
            {
                inputList.Add((input.ElementAt(i)));
            }
            Console.WriteLine("Reversed Input");
            foreach (char charcter in inputList.Reverse<char>())
            {
                Console.Write(charcter);
            }
            Console.WriteLine();
            Console.Write("Press any key to end program...");
            Console.ReadKey();
        }
    }
}
