using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder a_stringBuilder = new StringBuilder();

            string hello = "Hello";

            a_stringBuilder.Append("Hi");
            a_stringBuilder.Append(" Coder!");
            a_stringBuilder.Append(hello);
            a_stringBuilder.Clear();
            a_stringBuilder.AppendLine();

            int.Parse(a_stringBuilder.ToString());

            Console.WriteLine(a_stringBuilder);
        }
    }
}
