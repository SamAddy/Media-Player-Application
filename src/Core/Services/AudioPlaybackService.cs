using MediaPlayer.src.Core.Attributes;
using MediaPlayer.src.Core.Interfaces;

namespace MediaPlayer.src.Core.Services 
{
    [MediaPlayerType("audio")]
    public class AudioPlaybackService : IPlaybackService
    {
        public void Play()
        {
            Console.WriteLine("Playing audio file.");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing audio playback.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping audio playback.");
        }

        public void Seek()
        {
            throw new NotImplementedException();
        }
    }
}