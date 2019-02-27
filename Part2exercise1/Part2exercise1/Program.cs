using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int Min = 1000;
            int Max = 9999;
            Random randNum = new Random();
            int[] ranArray = Enumerable
                .Repeat(0, input)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            Array.Sort(ranArray);

            foreach (var item in ranArray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

        }
    }
}
