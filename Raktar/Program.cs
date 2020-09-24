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
        static List<Termek> termekek = new List<Termek>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                termekek.Add(new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
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
