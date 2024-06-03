using System.Net.NetworkInformation;

namespace doghotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            dogHotel.PrintInfo();
            dogHotel.PrintFeedingSchedule();
            dogHotel.PrintPickups();
        }

        static void AddTestData(DogHotel dogHotel)
        {
            DateTime droptime1 = new DateTime(2024, 04, 29, 10, 00, 00);
            DateTime pickuptime1 = new DateTime(2024, 05, 03, 19, 30, 00);
            DateTime droptime2 = new DateTime(2024, 04, 30, 08, 30, 00);
            DateTime pickuptime2 = new DateTime(2024, 04, 2, 19, 30, 00);
            Visit visit1 = new Visit(droptime1, pickuptime1);
            Visit visit2 = new Visit(droptime2, pickuptime2);
            Adress testAdress1 = new Adress("gata1", "stad1", "postnummer1");
            Adress testAdress2 = new Adress("gata2", "stad2", "postnummer2");
            Owner testOwner1 = new Owner("firstname1", "lastname2", testAdress1);
            Owner testOwner2 = new Owner("firstname2", "lastname2", testAdress2);
            Dog testDog1 = new Dog("fido", "123456", testOwner1, visit1);
            Dog testDog2 = new Dog("lassie", "654321", testOwner2, visit2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);

            Meal meal1 = new Meal(7, "Pedigree Adult Maxi Beef & Rice", "två skopor");
            Meal meal2 = new Meal(13, "Doggy paté med kalkon", "en halv burk");

            testDog1.AddMeal(meal1);
            testDog2.AddMeal(meal2);
        }
    }
}