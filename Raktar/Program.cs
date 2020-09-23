using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{

    class Program
    {
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
               // Console.WriteLine(sor[0]);
            }
            raktar.Close();
        }
        static void Main(string[] args)
        {
            Termek t = new Termek("P01", "Póló XXL", 1500, 10);
            BeolvasRaktar();

            Console.WriteLine($"{t.Kod} - {t.Nev} - {t.Ar} - {t.DB}");
            Console.ReadKey();
        }
    }
}
