using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exo 1 :");
            double result = 12 + 5 * 12.5 - 1253.68;
            Console.WriteLine(result);
            Console.ReadLine();


            Console.WriteLine("Exo 2 :");
            Console.Write("Entrez un rayon de cercle :");
            var rayon = Int32.Parse(Console.ReadLine());

            var surface = Math.PI * rayon * rayon;
            var perimetre = 2 * Math.PI * rayon;

            Console.WriteLine("Périmètre : " + perimetre);
            Console.WriteLine("Surface : " + surface);
            Console.ReadLine();
        }
    }
}
