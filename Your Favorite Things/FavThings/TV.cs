using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.FavThings
{
    class TV
    {
        public string TVGenre { get; set; }
        public short Seasons { get; set; }

        public void SelectShow()
        {
            Console.WriteLine($"Currently playing a {TVGenre} show.");
        }

        public TV(string tvgenre, short seasons)
        {
            TVGenre = tvgenre;
            Seasons = seasons;
        }

        public void NumofSeasons()
        {
            Console.WriteLine($"This show has {Seasons} seasons.");
        }
    }
}
