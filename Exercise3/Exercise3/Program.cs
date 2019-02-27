using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = divideNum(50, 3);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static int divideNum(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }


    }
}
