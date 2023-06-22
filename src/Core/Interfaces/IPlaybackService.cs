namespace MediaPlayer.src.Core.Interfaces
{
    public interface IPlaybackService
    {
        void Play(string filePath);
        void Pause();
        void Stop();
        void Seek();
    }
}