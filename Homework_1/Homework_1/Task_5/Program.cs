using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string sa = Console.ReadLine();
            string sb = Console.ReadLine();
            bool ba = double.TryParse(sa, out a);
            bool bb = double.TryParse(sb, out b);
            if (ba && bb)
            {
                string c = (Math.Sqrt(a * a + b * b)).ToString("F2");

                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadKey();
        }
    }
}
