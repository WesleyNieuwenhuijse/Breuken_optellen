using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Breuk breuk1 = new Breuk();
            breuk1.Teller = 1;
            breuk1.Noemer = 6;
            Breuk breuk2 = new Breuk();
            breuk2.Teller = 2;
            breuk2.Noemer = 12;

            Bereken bereken = new Bereken();
            Breuk resultaat = bereken.OptellenBreuken(breuk1, breuk2);
            resultaat = bereken.Vereenvoudigen(resultaat);

            Console.WriteLine("Resultaat : " + resultaat.Teller + "/" + resultaat.Noemer);
            Console.Read();
        }
    }
}
