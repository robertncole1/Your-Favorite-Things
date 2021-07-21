using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.FavThings
{
    class Music
    {
        public string Genre { get; set; }
        public string Song { get; set; }

        public void Play()
        {
            Console.WriteLine($"{Genre} music playing now.");
        }

        public Music(string genre, string song)
        {
            Genre = genre;
            Song = song;
        }

        public void SelectSong()
        {
            Console.WriteLine($"{Song} now playing.");
        }
    }
}
