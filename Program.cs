using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_grados_radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce los grados:");
            double degree = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} grados son {1} radianes.", degree, fromDegreesToRadians(degree));
        }

        public static double fromDegreesToRadians(double d)
        {
            double result = 0;
            const double pi = 3.1416;

            result = d * pi / 180;

            return result; 

        }
    }
}
