using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    class MusicPlayer
    {
        private List<Song> playlist = new List<Song>();

        public void AddSong(string title, string artist, string filePath)
        {
            playlist.Add(new Song { Title = title, Artist = artist, FilePath = filePath });
        }

        public void RemoveSong(int index)
        {
            if (index >= 0 && index < playlist.Count)
            {
                playlist.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void DisplayPlaylist()
        {
            Console.WriteLine("Current Playlist:");
            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlist[i]}");
            }
        }

        public void PlaySong(int index)
        {
            if (index >= 0 && index < playlist.Count)
            {
                Console.WriteLine($"Playing: {playlist[index]}");
                
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void ShufflePlaylist()
        {
            Random rng = new Random();
            playlist = playlist.OrderBy(x => rng.Next()).ToList();
        }

        public void SortPlaylist()
        {
            playlist = playlist.OrderBy(song => song.Title).ToList();
        }
    }
}
