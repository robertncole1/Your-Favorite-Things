using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.FavThings
{
    class Movies
    {
        public string MovieGenre { get; set; }
        public short Length { get; set; }

        public void SelectGenre()
        {
            Console.WriteLine($"Currently playing a {MovieGenre} movie.");
        }

        public Movies(string moviegenre, short length)
        {
            MovieGenre = moviegenre;
            Length = length;
        }

        public void HowLong()
        {
            Console.WriteLine($"This movie is {Length} minutes long.");
        }
    }
}
