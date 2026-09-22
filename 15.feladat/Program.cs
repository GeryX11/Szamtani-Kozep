using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());

            Console.Write("Add meg az második számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            double kozep = (double)(szam1 + szam2) / 2;
            Console.WriteLine($"A számtani kőzép: {kozep}");
            Console.ReadKey();
        }
    }
}
