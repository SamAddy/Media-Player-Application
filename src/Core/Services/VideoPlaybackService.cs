using MediaPlayer.src.Core.Attributes;
using MediaPlayer.src.Core.Interfaces;

namespace MediaPlayer.src.Core.Services
{
    [MediaPlayerType("video")]
    public class VideoPlaybackService : IPlaybackService
    {
        public void Play()
        {
            Console.WriteLine("Playing video file ");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing video playback.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping video playback.");
        }

        public void Seek()
        {
            throw new NotImplementedException();
        }
    }
}