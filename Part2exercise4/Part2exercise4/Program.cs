using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers seperated by commas: ");
            string input = Console.ReadLine();

            string[] numbersStr = input.Split(',');

            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            Array.Sort(numbers);

            int highest = numbers[numbers.Length - 1];
            int lowest = numbers[0];
            int average = 0;

            int x = 1;
            foreach (int num in numbers)
            {
                average = num + average;
                    x += 1;
            }
            average = average / x;
            

            Console.WriteLine("The highest number is: " + highest);
            Console.WriteLine("The lowest number is: " + lowest);
            Console.WriteLine("The average number is: " + average);

            Console.ReadLine();
        }
    }
}
