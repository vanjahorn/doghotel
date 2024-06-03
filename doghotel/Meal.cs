using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace doghotel
{
    internal class Meal
    {
        public int hourOfDay;
        public string foodType;
        public string amount;

        public Meal(int hD, string fT, string am)
        {
            hourOfDay = hD;
            foodType = fT;
            amount = am;
        }

        public override string ToString()
        {
            return "kl " + hourOfDay + ": " + foodType + " " + amount;
        }
    }
}
