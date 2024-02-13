namespace FunWithMusic
{
    internal class Program
    {
        enum Genre
        {
            Hiphop,
            DrumAndBass,
            Jazz,
            Classical,
            Soul
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album +
                    "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("Which album is the song from?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How long is the song? (Use format 0:00)");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("H - hip-hop\nD - Drum and bass \nJ - Jazz\nC - Classical\nS - Soul");
            Genre tempGenre = Genre.Jazz;
            char g = char.Parse(Console.ReadLine());
            switch(g)
            {
                case 'H':
                    tempGenre = Genre.Hiphop;
                    break;
                case 'D':
                    tempGenre = Genre.DrumAndBass;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'C':
                    tempGenre = Genre.Classical;
                    break;
                case 'S':
                    tempGenre = Genre.Soul;
                    break;
                default:
                    Console.WriteLine("Please select form one of the genres above.");
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music moreMusic = music;
            Console.WriteLine("What is the next song on the album?");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("How long is the song? (Use format 0:00)");
            moreMusic.setLength(Console.ReadLine());
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}
