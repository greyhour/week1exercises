using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("----------");
                string input = Console.ReadLine();
                if (input == "swap")
                {
                    Console.WriteLine("Variable A: ");
                    string A = Console.ReadLine();
                    Console.WriteLine("Variable B: ");
                    string B = Console.ReadLine();
                    Console.WriteLine("Variable 1: " + optionSwap(A, B)[0]);
                    Console.WriteLine("Variable 2: " + optionSwap(A, B)[1]);
                }
                else if (input == "multiply")
                {  
                    Console.WriteLine("First Number: ");
                    string num1Str = Console.ReadLine();

                    Console.WriteLine("First Second: ");
                    string num2Str = Console.ReadLine();

                    Console.WriteLine(num1Str + " x " + num2Str + " = " + multiply(num1Str, num2Str));
                }
                else if (input == "times table")
                {
                    Console.WriteLine("Input number: ");
                    string inputStr = Console.ReadLine();

                    int num = 0;
                    int x = 1;
                    do
                    {
                        Console.WriteLine(optionTimesTbl(inputStr)[num]);
                        x += 1;
                        num += 1;
                    } while (x != 11);
                    
                }
                else if (input == "end")
                {
                    i = +1;
                }
                else if (input == "help")
                {
                    Console.WriteLine(">swap");
                    Console.WriteLine(">multiply");
                    Console.WriteLine(">times table");
                    Console.WriteLine(">end");
                    Console.WriteLine(">help");
                }
                else
                {
                    Console.WriteLine("Unknown Command. Type 'end' to emd the program");
                }
            }
        }

        public static string[] optionSwap(string A, string B)
        {
            Swap(ref A, ref B);
            string[] swapArray = new string[2];
            swapArray[0] = A;
            swapArray[1] = B;
            return swapArray;
        }
        public static void Swap<T>(ref T var1, ref T var2)
        {
            T temp = var1;
            var1 = var2;
            var2 = temp;
        }

        public static int multiply(string num1Str, string num2Str)
        {
            int num1;
            int num2;
            Int32.TryParse(num1Str, out num1);
            Int32.TryParse(num2Str, out num2);

            int result = num1 * num2;
            return result;
        }

        public static string[] optionTimesTbl(string inputStr)
        {
            double input;
            input = Convert.ToDouble(inputStr);
            string[] answer = new string[10];
            int x = 0;
            int num = 1;
            do
            {
                answer[x] = multiplyTable(input, num);
                x += 1;
                num += 1;
            } while (x != 10);

            return answer;
        }
        static string multiplyTable(Double main, Double num)
        {
            Double answr = main * num;
            string line = main + " x " + num + " = " + answr;
            return line;
        }
    }
}
