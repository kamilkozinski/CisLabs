using System;
using System.Collections;
using System.Collections.Generic;

namespace zad1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array2 = new string[5];
            array2[0] = "jas";
            array2[1] = "fasola";
            array2[2] = "sra";
            array2[3] = "do";
            array2[4] = "gara";

            List<String> myList = new List<String>
            {
                "AA",
                "DUPOL",
            };
         //   for (int i = 0; i < array2.Length; i++)
         //   {
           //     Console.WriteLine(array2[i]);

          //  }
            foreach (string element in array2)
            {
                Console.WriteLine(element);
            
            }

            myAlbum album = new myAlbum();
            // album.ShowAlbumInfo();
            myAlbum album3 = new myAlbum("Dupa","CBUL",3, 2000);
            album3.ShowAlbumInfo();
            Console.WriteLine(myAlbum.HowManyAlbums);
        }
    }
}
