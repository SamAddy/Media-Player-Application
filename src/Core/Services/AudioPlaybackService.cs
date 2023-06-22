using MediaPlayer.src.Core.Interfaces;

namespace MediaPlayer.src.Core.Services 
{
    public class AudioPlaybackService : IPlaybackService
    {
        public void Play(string filePath)
        {
            Console.WriteLine("Playing video file: " + filePath);
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