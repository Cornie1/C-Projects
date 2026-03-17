using System;
using System.Media;
using System.IO;

namespace AudioExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // string filepath = "D:\\Video Edit\\Video Editing stuff\\Video Editing stuff sounds ect\\bamboo-hit-anime-bonk-sound.mp3"; //has to be compatible with the media player .wav in this case

            //SoundPlayer player = new SoundPlayer(filepath);

            //player.Play();
            //Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("This font is green");
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("the background is red");

            Console.ResetColor();
            Console.WriteLine("This is default colour scheme");

            Console.ReadKey();
        }
    }
}
