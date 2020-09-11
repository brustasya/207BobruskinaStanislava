using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R;
            string su = Console.ReadLine();
            string sr = Console.ReadLine();
            bool bu = double.TryParse(su, out U);
            bool br = double.TryParse(sr, out R);
            if (bu && br)
            {
                string I = (U / R).ToString("F2");
                string P = (U * U / R).ToString("F2");
                Console.WriteLine("I = " + I);
                Console.WriteLine("P = " + P);
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadKey();
        }
    }
}
