using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotel
{
    internal class Dog
    {
        public Visit visit;
        public string name;
        public string chipNumber;
        public Owner owner;
        public List<Meal> mealList = new List<Meal>();
        public Meal meal;

        public Dog(string n, string c, Owner o, Visit v)
        {
            name = n;
            chipNumber = c;
            owner = o;
            visit = v;
        }

        internal string GetName()
        {
            return name;
        }

        internal string GetOwner()
        {
            string fN = owner.firstName;
            string lN = owner.lastName;
            string a = owner.GetAdress();
            string ownerInfo = fN + " " + lN + " " + a;
            return ownerInfo;
        }

        public void AddMeal(Meal meal)
        {
            mealList.Add(meal);
        }

        internal string GetVisit()
        {
            string dropoff = visit.dropoffTime.ToString();
            string pickup = visit.pickupTime.ToString();
            string timeinfo = dropoff + " " + pickup;
            return timeinfo;
        }
    }
}
