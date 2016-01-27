using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        private List<Song> songs;

        public override string ToString()
        {
            return Name + " " + Artist + " ";
        }
        public CD()
        {
            songs = new List<Song>();
        }
        
        public void AddSong(Song song)
        {
            songs.Add(song);
        }
        public void PrintCollection()
        {
            Console.WriteLine("Songs in a CD: ");
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
