namespace MusicArray
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
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of the song?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("Which album is the song from?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("How long is the song? (Use format 0:00)");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("H - hip-hop\nD - Drum and bass \nJ - Jazz\nC - Classical\nS - Soul");
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'H':
                            collection[i].setGenre(Genre.Hiphop);
                            break;
                        case 'D':
                            collection[i].setGenre(Genre.DrumAndBass);
                            break;
                        case 'J':
                            collection[i].setGenre(Genre.Jazz);
                            break;
                        case 'C':
                            collection[i].setGenre(Genre.Classical);
                            break;
                        case 'S':
                            collection[i].setGenre(Genre.Soul);
                            break;
                        default:
                            Console.WriteLine("Please select from one of the genres above.");
                            break;
                    }
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0;  i < collection.Length; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}
