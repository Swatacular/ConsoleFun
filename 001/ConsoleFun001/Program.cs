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
            Console.WriteLine("Hello!, I will reverse your number or word for you!");
            Console.Write("Please enter your number or word: ");
            string stringInput;
            //Added the below code so it wouldn't work with any charcters and only work with numbers
            int input;
            while (true)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("You have not entered a valid number");
                    Console.WriteLine();
                    Console.Write("Please enter your number or word: ");
                }
            }
            stringInput = input.ToString();
            //--------
            List<char> inputList = new List<char>(); //char is like a string, except it only contains one character
            //A simple for loop. i++ adds one for every time the loop runs, and it keeps on running untill i is greater than or equal to the number of charcters in the list.
            for (int i = 0; i < stringInput.Count<char>(); i++)
            {
                inputList.Add(stringInput.ElementAt(i));
            }
            Console.WriteLine("Here is the reversed version.");
            //A foreach loop, it takes an array or list and writes the charcter to each item in the list.
            foreach (char charcter in inputList.Reverse<char>()) //The list that this loop is running is actually a reversed version of it using the .reverse method.
            {
                Console.Write(charcter);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to end program...");
            Console.ReadKey();
        }
    }
}
