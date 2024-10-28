using System;

namespace ProxyPattern
{
    public class VideoProxy : IVideo
    {
        private readonly string _videoFile;
        private RealVideo _realVideo;

        public VideoProxy(string videoFile)
        {
            _videoFile = videoFile;
        }

        public void Play()
        {
            if (_realVideo == null) _realVideo = new RealVideo(_videoFile);
            _realVideo.Play();
        }
    }

    public interface IVideo
    {
        void Play();
    }

    public class RealVideo : IVideo
    {
        private readonly string _videoFile;

        public RealVideo(string videoFile)
        {
            _videoFile = videoFile;
            LoadVideo();
        }

        public void Play()
        {
            Console.WriteLine($"Playing video: {_videoFile}");
        }

        private void LoadVideo()
        {
            Console.WriteLine($"Loading video: {_videoFile}");
        }
    }
}