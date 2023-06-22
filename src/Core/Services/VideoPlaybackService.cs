using MediaPlayer.src.Core.Interfaces;

namespace MediaPlayer.src.Core.Services
{
    public class VideoPlaybackService : IPlaybackService
    {
        public void Play(string filePath)
        {
            Console.WriteLine("Playing video file: " + filePath);
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