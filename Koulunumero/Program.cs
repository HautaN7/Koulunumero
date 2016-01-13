using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulunumero
{
    class Program
    {
        static void Main(string[] args)
        {

            int pisteet;

            Console.Write("Anna pisteet: ");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet >= 0 && pisteet <= 1) Console.WriteLine("Numero: 0");
            if (pisteet >= 2 && pisteet <= 3) Console.WriteLine("Numero: 1");
            if (pisteet >= 4 && pisteet <= 5) Console.WriteLine("Numero: 2");
            if (pisteet >= 6 && pisteet <= 7) Console.WriteLine("Numero: 3");
            if (pisteet >= 8 && pisteet <= 9) Console.WriteLine("Numero: 4");
            if (pisteet >= 10 && pisteet <= 12) Console.WriteLine("Numero: 5");

            Console.ReadLine();

        }
    }
}
