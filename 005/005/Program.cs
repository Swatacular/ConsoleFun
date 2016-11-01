using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = (int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Drill A:");
            Console.WriteLine(DrillA(num));

            Console.WriteLine("Drill B:");
            Console.WriteLine(DrillB(num));

            Console.WriteLine("Drill C:");
            Console.WriteLine(DrillC(num));

            Console.WriteLine("Drill D:");
            Console.WriteLine(DrillD(num));

            Console.WriteLine("Drill E:");
            Console.WriteLine(DrillE(num));
            
            Console.WriteLine("Drill F:");
            Console.WriteLine(DrillF(num));

            Console.WriteLine("Drill G:");
            Console.WriteLine(DrillG(num));
            
            Console.WriteLine("Drill H:");
            Console.WriteLine(DrillH(num));
            
            Console.WriteLine("Drill I:");
            Console.WriteLine(DrillI(num));

            Console.WriteLine("Drill J:");
            Console.WriteLine(DrillJ(num));
            Console.ReadKey();
        }

        public static long CalculateFacorial(int num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        public static string DrillA(int length)
        {
            string answer = "";

            for (int i = 1; i <= length; i++)
            {
                for (int ii = 1; ii <= length; ii++)
                {
                    if (ii <= i) answer += "#".PadRight(2);
                    else answer += "".PadRight(2);
                }
                answer += "\n";
            }
            return answer;
        }

        public static string DrillB(int length)
        {
            string answer = "";

            for (int i = 1; i <= length; i++)
            {
                for (int ii = 1; ii <= length; ii++)
                {
                    if (ii <= 1 + length - i) answer += "#".PadRight(2);
                    else answer += "".PadRight(2);
                }
                answer += "\n";

            }

            return answer;
        }

        public static string DrillC(int length)
        {
            string answer = "";

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if (row <= column) answer += "#".PadRight(2);
                    else answer += "".PadRight(2);
                }
                answer += "\n";
            }

            return answer;
        }

        public static string DrillD(int length)
        {
            StringBuilder answer = new StringBuilder();
            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if (column > length - row) answer.Append("#".PadRight(2));
                    else answer.Append("".PadRight(2));
                }
                answer.Append("\n");
            }
            return answer.ToString();
        }

        public static string DrillE(int length)
        {
            string answer = "";

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if (column == 1 || column == length || row == 1 || row == length)
                    {
                        answer += "#".PadRight(2);
                        //Console.Write("#".PadRight(2));
                    }
                    else answer += "".PadRight(2);//Console.Write("".PadRight(2));
                }
                answer += "\n";
            }

            return answer;
        }

        public static string DrillF(int length)
        {
            string answer = "";

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if ((row == column) || row == 1 || row == length)
                    {
                        answer += "#".PadRight(2);
                    }
                    else answer += "".PadRight(2);
                }
                answer += "\n";
            }

            return answer;
        }

        public static string DrillG(int length)
        {
            string answer = "";

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if ((column == 1 + length - row) || row == 1 || row == length)
                    {
                        answer += "#".PadRight(2);
                    }
                    else answer += "".PadRight(2);
                }
                answer += "\n";
            }

            return answer;
        }
        
        public static string DrillH(int length)
        {
            string answer = "";

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if ((row == column) || (column == 1 + length - row) || row == 1 || row == length)
                    {
                        answer += "#".PadRight(2);
                    }
                    else answer += "".PadRight(2);
                }
                answer += "\n";
            }

            return answer;
        }
        
        public static string DrillI(int length)
        {
            string answer = "";

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if ((row == column) || (column == 1 + length - row) || row == 1 || row == length || column == 1 || column == length)
                    {
                        answer += "#".PadRight(2);
                    }
                    else answer += "".PadRight(2);
                }
                answer += "\n";
            }
            return answer;
        }

        public static string DrillJ(int length)
        {
            string answer = "";

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length; column++)
                {
                    if ((row == column) || (column == 1 + length - row) || row == 1 || row == length || column == 1 || column == length)
                    {
                        answer += "#".PadRight(2);
                    }
                    else answer += "".PadRight(2);
                }
                answer += "\n";
            }
            return answer;
        }
        
    }
}
