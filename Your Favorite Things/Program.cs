using Your_Favorite_Things.FavThings;
using System;

namespace Your_Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            var PopSong = new Music("Pop", "Toxic");

            PopSong.Play();
            PopSong.SelectSong();

            var RapSong = new Music("Rap", "I Don't F$*K With You");

            RapSong.Play();
            RapSong.SelectSong();

            var NewFood = new Food("American", "Lunch");

            NewFood.SelectType();
            NewFood.When();

            var NewFood2 = new Food("French", "Dinner");

            NewFood2.SelectType();
            NewFood2.When();

            var NewMovie = new Movies("Action", 120);

            NewMovie.SelectGenre();
            NewMovie.HowLong();

            var NewMovie2 = new Movies("Romance", 115);

            NewMovie2.SelectGenre();
            NewMovie2.HowLong();

            var NewShow = new TV("Drama", 4);

            NewShow.SelectShow();
            NewShow.NumofSeasons();

            var NewShow2 = new TV("Comedy", 7);

            NewShow2.SelectShow();
            NewShow2.NumofSeasons();
        }
    }
}
