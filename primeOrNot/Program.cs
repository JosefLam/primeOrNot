using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter start number");
            int min = 0;
            int.TryParse(Console.ReadLine(), out min);

            Console.WriteLine("enter end number");
            string endNum = Console.ReadLine();

        }
    }
}
