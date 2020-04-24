using System;
using System.Collections.Generic;
using System.Text;

namespace zad1._3
{
    class myAlbum
    {
      

        public string Name
        {
            get;
            set;
        }
        public string Artist
        {
            get;
            set;
        }
        public int Track
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;

        }
        public static int HowManyAlbums
        {
            get;
            set;

        }
        public static void CleanAlbumCounter()
        {
            myAlbum.HowManyAlbums = 0;
        }
        public myAlbum()
        {
            Name = "Unknwn";
            Artist = "Unknwn";
            Track = 0;
            Year = 0;
            myAlbum.HowManyAlbums++;
        }
        public myAlbum(string name,int year)
        {
            Artist = "Unknwn";
            Name = name;
            Year = year;
            Track = 0;
            myAlbum.HowManyAlbums++;
        }
        public myAlbum(string name, string artist, int track, int year)
        {
            if (year < 2021) { Name = name; }
            Artist = artist;
            Track = track;
            Year = year;
            myAlbum.HowManyAlbums++;

        }


        public void ShowAlbumInfo()
        {
            Console.WriteLine(Name +" "+ Artist + " " + Track + " " + Year + " ");

        }

    }
}
