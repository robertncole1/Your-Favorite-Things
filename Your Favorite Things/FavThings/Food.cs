using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.FavThings
{
    class Food
    {
        public string Country { get; set; }
        public string Time { get; set; }

        public void SelectType()
        {
            Console.WriteLine($"Currently serving {Country} food.");
        }

        public Food(string country, string time)
        {
            Country = country;
            Time = time;
        }

        public void When()
        {
            Console.WriteLine($"It is now time for {Time}.");
        }
    }
}
