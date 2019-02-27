using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variable A: ");
            string A = Console.ReadLine();
            Console.WriteLine("Variable B: ");
            string B = Console.ReadLine();

            Swap(ref A, ref B);
            Console.WriteLine("Variable A: " + A);
            Console.WriteLine("Variable B: " + B);
            Console.ReadLine();
        }

        public static void Swap<T>(ref T var1, ref T var2)
        {
            T temp = var1;
            var1 = var2;
            var2 = temp;
        }
    }
}
