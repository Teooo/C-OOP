using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRadioDatabase
{
    public class InvalidSongException : Exception
    {
        public const string Message = "Invalid song.";

        public InvalidSongException()
            : base(Message)
        {

        }
        public InvalidSongException(string message)
            : base(message)
        {
        }
    }

    public class InvalidArtistNameException : InvalidSongException
    {
        public static string message = "Artist name should be between 3 and 20 symbols.";
        public InvalidArtistNameException()
            : base(message)
        {
        }
    }

    public class InvalidSongLengthException : InvalidSongException
    {
        public static string message = "Invalid song length.";

        public InvalidSongLengthException()
            : base(message)
        {


        }
        public InvalidSongLengthException(string songMinutesShouldBeBetweenAnd)
            : base(songMinutesShouldBeBetweenAnd)
        {
        }
    }

    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public static string message = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException()
            : base(message)
        {
        }
    }

    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public static string message = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException()
            : base(message)
        {
        }
    }
    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;
       

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public string ArtistName
        {
            get
            {
                return this.artistName;

            }
            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }
            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidSongException();
                }
                this.songName = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            private set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

    }

    class OnlineRadioDatabase
    {
        static void Main()
        {
            int numberOfLine = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] songParams = Console.ReadLine().Split(';');
                string artistName = songParams[0];
                string songName = songParams[1];
                try
                {
                    int[] lenght = songParams[2].Split(':').Select(int.Parse).ToArray();
                    Song song = new Song(artistName, songName, lenght[0], lenght[1]);

                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Songs added: {songs.Count}");
            int totalMinutes = songs.Sum(x => x.Minutes);
            int totalSecond = songs.Sum(x => x.Seconds);

            totalSecond += totalMinutes * 60;
            int finalMinets = totalSecond / 60;

            int finelSecond = totalSecond % 60;
            int finalHours = finalMinets / 60;
            finalMinets %= 60;

            Console.WriteLine($"Playlist length: {finalHours}h {finalMinets}m {finelSecond}s");
        }
    }
}
