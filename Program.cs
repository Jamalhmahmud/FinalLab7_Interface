using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab7a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator interface");

            BasicCalclmp a1 = new BasicCalclmp();

            Console.WriteLine(a1.sum(15, 8));
            Console.WriteLine(a1.sub(25, 8));
            Console.WriteLine(a1.multiplication(5, 8));
            Console.WriteLine(a1.division(64, 8));



            Console.ReadKey();


        }
    }
}
