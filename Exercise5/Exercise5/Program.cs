using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double input;
            Console.WriteLine("Input number: ");
            string inputStr = Console.ReadLine();
            input = Convert.ToDouble(inputStr);

            int x = 1;
            do
            {
                Console.WriteLine(multiplyTable(input, x));
                x += 1;
            } while (x != 11);

            Console.ReadLine();
        }

        static string multiplyTable(Double main, Double num)
        {
            Double answr = main * num;
            string line = main + " x " + num + " = " + answr;
            return line;
        }
    }
}
