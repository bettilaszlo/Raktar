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
        public Termek(string kod, string nev, int ar, int db)
        {
            this.kod =kod;
            this.nev = nev;
            this.ar = ar;
            this.db = db;

        }
       
    }
}
