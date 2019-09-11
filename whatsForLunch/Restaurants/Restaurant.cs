using System;
using System.Collections.Generic;
using System.Text;

namespace whatsForLunch.Restaurants
{
    class Restaurant
    {
        public string Name { get; set; }

         private List<string> _restaurants = new List<string>
        { "Chuy's", "Taco Bell", "McDonald", "Subway" };

        public Restaurant()
        {
            var rnd = new Random();
            var index = rnd.Next(_restaurants.Count);
            var randRestName = _restaurants[index];
            Name = randRestName;

        }
        public void GetRndRestName()
        {
            Console.WriteLine(Name);
        }
    }
}
