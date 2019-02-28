using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Names divided by commas: ");
            string data = Console.ReadLine();

            string[] names = data.Split(',');

            Array.Sort(names);

            string[] finalNames = new string[names.Length];

            names.CopyTo(finalNames, 0);

            foreach (string word in finalNames)
            {
                Console.WriteLine("WORD: " + word);
            }



            Console.ReadLine();
        }
    }
}
