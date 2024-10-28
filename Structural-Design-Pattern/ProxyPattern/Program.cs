using System;

namespace ProxyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IVideo video = new VideoProxy("sample.mp4");

            Console.WriteLine("Video object created.");
            Console.WriteLine("Now playing video:");

            video.Play();
        }
    }
}