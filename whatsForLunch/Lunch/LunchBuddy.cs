using System;
using System.Collections.Generic;
using System.Text;
using whatsForLunch.Restaurants;

namespace whatsForLunch.Lunch
{
    class LunchBuddy
    {
        public string BuddyFirstName { get; set; }
        public string BuddyLastName { get; set; }

        public LunchBuddy(string buddyFName, string buddyLName)
        {
            BuddyFirstName = buddyFName;
            BuddyLastName = buddyLName;
        }

        public void giveGetLunchBuddyFullName()
        {
            Console.WriteLine($"{BuddyFirstName} {BuddyLastName}");
        }

        public void Eat()
        {
            var getRandRestName = new Restaurant();
            getRandRestName.GetRndRestName();
        }

        public void Eat(string food)
        {

        }

    }
}
