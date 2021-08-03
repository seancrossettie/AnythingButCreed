using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>(5);

            allSongs.Add(new Song("Creed", "Take Me Higher"));
            allSongs.Add(new Song("Hinder", "Lips of An Angel"));
            allSongs.Add(new Song("Shinedown", "Second Chance"));
            allSongs.Add(new Song("Daughtry", "It's Not Over"));
            allSongs.Add(new Song("Creed", "With Arms Wide Open"));
            allSongs.Add(new Song("Post Malone", "Rockstar"));
            allSongs.Add(new Song("Red Hot Chili Peppers", "Otherside"));
            allSongs.Add(new Song("Queens of the Stone Age", "No One Knows"));
            allSongs.Add(new Song("Creed", "My Sacrifice"));
            allSongs.Add(new Song("Pearl Jam", "Alive"));
            allSongs.Add(new Song("Alice in Chains", "Man in the Box"));
            allSongs.Add(new Song("Nirvana", "In Bloom"));

            IEnumerable<Song> goodTunes = allSongs.Where(song => song.Artist != "Creed");

            goodSongs.AddRange(goodTunes);

            foreach(var tune in goodSongs)
            {
                Console.WriteLine($"{tune.Artist} : {tune.Name}");
            }
        }
    }
}
