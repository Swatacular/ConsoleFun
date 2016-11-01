using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;


            if(GetValidInput(out input) == true)
            {
                //yada yada do something with input.
            }
            else
            {
                //user did something wrong
            }


            Console.ReadKey();

        }

        private static bool GetValidInput(out int input)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                input = x;
                return true;
            }
            catch (FormatException exceptionLikeInception)
            {
                //Console.WriteLine(exceptionLikeInception.Message);

                Console.WriteLine(exceptionLikeInception.StackTrace);
                Console.WriteLine("You entered wrong string! Call GrandCircus!");
                input = -1;
                return false;

            }
            catch (OverflowException)
            {
                Console.WriteLine("Wooo, slow down! This is a really big number!");
                input = -1;
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("What, How?");
                input = -1;
                return false;
            }
        }

        static string M1(int input)
        {
            if (input <= 100)
                return "A";
            else if (input <= 80)
                return "B";

            else return "F";

        }
    }
}
