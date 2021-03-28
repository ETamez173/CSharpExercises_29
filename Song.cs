using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises_29
{
    class Song
    {
        // static attributes in classes in C#
        // special type of attribute in a class that is shared by ALL objects AND 
        // ALL instances of that class
        // AKA an attribute that is on the class vs being on the object of the class

        public string title;
        public string artist;
        public int duration;
        // create static variable and we set to 0
        public static int songCount = 0;

        // this is a contructor to create a new song object
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            // each time song object is created we increment the count
            songCount++;
        }

        // this getter method returns the songcount on each object if you want
        public int getSongCount()
        {
            return songCount;
        }

    }
}
