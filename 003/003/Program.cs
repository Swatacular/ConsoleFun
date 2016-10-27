using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {

            string playGame = "yes";

            while (playGame == "yes")
            {
                //do something here



                Console.WriteLine("Do you want to continue?");
                playGame = Console.ReadLine();
            }
        }
    }
}
