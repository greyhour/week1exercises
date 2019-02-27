using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {

        static void Main(string[] args)
        {
            double radius;
            string radiusStr = Console.ReadLine();
            radius = Convert.ToDouble(radiusStr);

            Console.WriteLine(perimiter(radius));
            Console.WriteLine(area(radius));
            Console.ReadLine();
        }

        private static double perimiter(double r)
        {
            double finalPermtr = 2 * Math.PI * r;
            return finalPermtr;
        }

        private static double area(double r)
        {
            double finalArea = Math.PI * r * r;
            return finalArea;
        }

    }
}
