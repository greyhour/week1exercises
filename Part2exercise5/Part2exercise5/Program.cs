using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Random ranNum = new Random();
            int[] ranArray = Enumerable
                .Repeat(0, number)
                .Select(i => ranNum.Next(0, 11))
                .ToArray();

            int[] arr2 = new int[number];
            int[] arr3 = new int[number];
            ranArray.CopyTo(arr2, 0);
            ranArray.CopyTo(arr3, 0);

            Array.Sort(arr2);
            Array.Sort(arr3);
            Array.Reverse(arr3);

            Console.WriteLine("---------------");
            write(arr2);
            Console.WriteLine("---------------");
            write(arr3);

            Console.ReadLine();

        }

        public static void write(int[] arr)
        {
            for (int i = 1; i <= arr.Length;) {
                for (int j = 0; j < 5; j++) {
                    Console.Write(arr[i - 1] + ", ");
                    i++;
                    if (i >= arr.Length) {
                        Console.Write(arr[i - 1]);
                        i++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
