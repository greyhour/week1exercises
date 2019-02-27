using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            int Min = 1000;
            int Max = 9999;
            Random randNum = new Random();
            int[] ranArray = Enumerable
                .Repeat(0, 100)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();
            foreach (var item in ranArray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
