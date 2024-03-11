using MusicPlayerApp;

class Program
{
    static void Main(string[] args)
    {
        MusicPlayer player = new MusicPlayer();

        while (true)
        {
            Console.WriteLine("\n1. Add Song");
            Console.WriteLine("2. Remove Song");
            Console.WriteLine("3. Display Playlist");
            Console.WriteLine("4. Play Song");
            Console.WriteLine("5. Shuffle Playlist");
            Console.WriteLine("6. Sort Playlist");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter song title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter artist name: ");
                    string artist = Console.ReadLine();
                    Console.Write("Enter file path: ");
                    string filePath = Console.ReadLine();
                    player.AddSong(title, artist, filePath);
                    break;
                case "2":
                    Console.Write("Enter index of song to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int indexToRemove))
                    {
                        player.RemoveSong(indexToRemove - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "3":
                    player.DisplayPlaylist();
                    break;
                case "4":
                    Console.Write("Enter index of song to play: ");
                    if (int.TryParse(Console.ReadLine(), out int indexToPlay))
                    {
                        player.PlaySong(indexToPlay - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "5":
                    player.ShufflePlaylist();
                    Console.WriteLine("Playlist shuffled.");
                    break;
                case "6":
                    player.SortPlaylist();
                    Console.WriteLine("Playlist sorted.");
                    break;
                case "7":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}