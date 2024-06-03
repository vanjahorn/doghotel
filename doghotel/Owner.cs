using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace doghotel
{
    internal class Owner
    {
        public string firstName;
        public string lastName;
        public Adress adress;

        public Owner(string fN, string lN, Adress a)
        {
            firstName = fN;
            lastName = lN;
            adress = a; 
        }
     
        internal string GetAdress()
        {
            string g = adress.gatuadress;
            string s = adress.stad;
            string p = adress.postnummer;
            string ownerAdress = g + " "+ s + " " + p;
            return ownerAdress;
        }
    }
}
