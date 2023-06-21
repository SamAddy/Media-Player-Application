using MediaPlayer.src.Core.Interfaces;

namespace MediaPlayer.src.Core.Services
{
    public class PlaybackService : IPlaybackService
    {
        public void Play()
        {
            Console.WriteLine("Playback started.");
        }

        public void Pause()
        {
            Console.WriteLine("Playback paused.");
        }

        public void Stop()
        {
            Console.WriteLine("Playback stopped.");
        }
    }
}