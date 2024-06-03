using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotel
{
    internal class Visit
    {
        public DateTime dropoffTime;
        public DateTime pickupTime;
        
        public Visit(DateTime dropoffTime, DateTime pickupTime) 
        { 
            this.dropoffTime = dropoffTime;
            this.pickupTime = pickupTime;
        }
        public override string ToString()
        {
            return "Lämna: " + dropoffTime + " Hämta: " + pickupTime;
        }
    }

}
