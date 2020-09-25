using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class Megrendeles
    {
        public string datum;
        public string Datum 
        {
            get { return datum; }
            set { datum = value; }
        }

        public string megrendelo;
        public string Megrendelo
        {
            get { return megrendelo; }
            set { megrendelo = value; }
        }

        public string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Megrendeles(string datum, string megrendelo, string email)
        {
            this.datum = datum;
            this.megrendelo = megrendelo;
            this.email = email;

        }

    }
}
