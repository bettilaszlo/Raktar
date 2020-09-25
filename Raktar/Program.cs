﻿using System;
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
        static List<Megrendeles> rendelesek = new List<Megrendeles>();
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
        static void BeolvasRendelesek()
        {
            StreamReader rendeles = new StreamReader("rendeles.csv");

            while (!rendeles.EndOfStream)
            {
                string[] sor = rendeles.ReadLine().Split(';');

                if (sor[0] == "M")
                {
                    rendelesek.Add(new Megrendeles(sor[1], sor[2], sor[3]));

                }
                // Console.WriteLine(sor[0]);
            }
            rendeles.Close();

        }
        static void Main(string[] args)
        {
            BeolvasRaktar();
            BeolvasRendelesek();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }


            foreach (var r in rendelesek)
            {
                Console.WriteLine(r.Email);
            }
            //Termek t = new Termek("P01", "Póló XXL", 1500, 10);
            //Console.WriteLine($"{t.Kod} - {t.Nev} - {t.Ar} - {t.DB}");
            Console.ReadKey();
        }
    }
}
