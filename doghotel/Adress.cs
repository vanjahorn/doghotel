using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotel
{
    internal class Adress
    {
        public string gatuadress;
        public string stad;
        public string postnummer;

        public Adress(string g, string s, string p)
        {
            gatuadress = g;
            stad = s;
            postnummer = p;
        }
    }
}
