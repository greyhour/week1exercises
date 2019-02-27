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
                else if (input == "Bye")
                {

                }
                else if (input == "Bye")
                {

                }
                else if (input == "end")
                {
                    i = +1;
                }
                else
                {
                    Console.WriteLine("Unknown Command");
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
    }
}
