using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 1;
            int Max = 100;
            Random randNum = new Random();
            int[] ranArray = Enumerable
                .Repeat(0, 100)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            foreach (var item in ranArray)
            {
                Console.WriteLine(item.ToString());
            }

            int sum = ranArray.Sum();

            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
    }
}
