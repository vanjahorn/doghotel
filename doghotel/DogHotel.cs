using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace doghotel
{
    internal class DogHotel
    {

        double costPerNight = 300;

        public Dog[] dogArray = new Dog[10];
       
        public void SetDog(int cageNumber, Dog dog)
        {
            dogArray[cageNumber] = dog;
        }

        public Dog GetDog(int cageNumber)
        {
            return dogArray[cageNumber];
        }

        public void PrintInfo()
        {
            for(int i = 0;  i < dogArray.Length; i++)
            {
                if (dogArray[i] != null)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Bur " + i + " : "+ dogArray[i].GetName());
                    Console.WriteLine("Ägare" + " : " + "\r\n" + dogArray[i].GetOwner());
                    Console.WriteLine("\r\n");
                }
            }
        }
       
        public void PrintFeedingSchedule()
        {
            for(int i = 0; i < dogArray.Length; i++)
            {
                Dog dog = dogArray[i];
                if (dog != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bur " + i + ": hund: " + dogArray[i].GetName());

                    foreach(Meal meal in  dog.mealList)
                    {
                        Console.WriteLine(meal.ToString() + "\r\n");
                    }
                }
            }
        }

        public void PrintPickups()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                Dog dog = dogArray[i];
                if (dog != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bur " + i + ": " + dogArray[i].GetName() + " Tider: " + dog.visit);
                }
            }
        }

        void PrintInvoice()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                Dog dog = dogArray[i];
                if (dog != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det finns ingen hund i buren!");
                }
            }


        }

    }
}
