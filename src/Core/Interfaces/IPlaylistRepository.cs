using MediaPlayer.src.Core.Entities;

namespace MediaPlayer.src.Core.Interfaces
{
    public interface IPlaylistRepository
    {
        public bool CreatePlaylist(Playlist playlist);
        public bool RemovePlaylist(Playlist playlist);
        List<Playlist> GetAllPlaylists();
        List<MediaFile> GetPlaylistFiles(string playlistName);
        List<MediaFile> GetPlaylistByName(string playlistName);
        public bool AddFileToPlaylist(string playlist, MediaFile mediaFile);
        public bool RemoveFileFromPlaylist(string playlist, MediaFile mediaFile);
    }
}