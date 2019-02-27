using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("First Number: ");
            string num1Str = Console.ReadLine();
            Int32.TryParse(num1Str, out num1);

            int num2;
            Console.WriteLine("First Second: ");
            string num2Str = Console.ReadLine();
            Int32.TryParse(num2Str, out num2);

            int result = num1 * num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
