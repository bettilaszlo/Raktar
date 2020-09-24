using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Termek
    {
        public string kod;
        public string Kod
        {
            get { return kod; }
            set { kod = value; }
        }

        public string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int ar;
        public int Ar
        {
            get { return ar; }
            set { ar = value; }
        }
        public int db;
        public int DB
        {
            get { return db; }
            set { db = value; }
        }
        public string Alakit(string szoveg)
        {
            string tmp = "";
            string ekezetes = "áéíóöőúüű";
            string mire = "aeiooouuu";

            for (int i = 0; i < szoveg.Length; i++)
            {
                int hol = ekezetes.IndexOf(szoveg[i]);

                if (hol > -1)
                {
                    tmp += mire[hol];
                }

                else
                {
                    tmp += szoveg[i];
                }
            }
                return tmp;

        }
        public Termek(string kod, string nev, int ar, int db)
        {
            this.kod =kod;
            this.nev = Alakit(nev);
            this.ar = ar;
            this.db = db;

        }
       
    }
}
