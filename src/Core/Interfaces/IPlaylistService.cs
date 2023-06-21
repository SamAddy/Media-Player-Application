namespace MediaPlayer.src.Core.Interfaces
{
    public interface IPlaylistService
    {
        void CreatePlaylist(string name);
        void AddMediaToPlaylist(string playlistName, string mediaName);
        void RemoveMediaFromPlaylist(string listName, string mediaName);
    }
}