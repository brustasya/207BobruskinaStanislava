using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            string sa = Console.ReadLine();
            code = int.Parse(sa);
            Console.WriteLine((char)(code));

            Console.ReadKey();
        }
    }
}
