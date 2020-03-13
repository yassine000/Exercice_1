using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class TestBatiment
    {
        static void Main(string[] args)
            // 11. tests des 2 classes
        {
            Maison m = new Maison(2002, 10000, "24, boulevard bois de boulogne, Montréal", 12);
            Immeuble i = new Immeuble(2010, 20000, "212, boulevard Sauvé, Montréal", 180);

            Console.WriteLine("---Test de la classe Maison---");
            Console.WriteLine(m.toString() + "\n");
            Console.WriteLine("---Test de la classe Immeuble---");
            Console.WriteLine(i.toString());
        }
    }
}
