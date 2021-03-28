using System;


// Static Class Attributes | C# | Tutorial 29

namespace CSharpExercises_29
{
    class Program
    {
        static void Main(string[] args)
        {

            // this calls the "Song"contructor within the class
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(holiday.title);
            Console.WriteLine(Song.songCount);

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.title);
            //Console.WriteLine(Song.songCount);

            // this method returns the songcount on each object if you want
            // using a getter method we put inside the class that returns songCount 
            // vs using the static class attribute above

            Console.WriteLine(kashmir.getSongCount());

            Console.WriteLine(holiday.artist);
            Console.WriteLine(kashmir.artist);
          

            Console.ReadLine();
        }
    }
}
