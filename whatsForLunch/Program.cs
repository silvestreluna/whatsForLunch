using System;
using whatsForLunch.Lunch;
using whatsForLunch.Restaurants;

namespace whatsForLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            var addBuddyFname = new LunchBuddy("test", "tes1");
            addBuddyFname.giveGetLunchBuddyFullName();
            addBuddyFname.Eat();

            var testing = new Restaurant();
            testing.GetRndRestName();
        }
    }
}
