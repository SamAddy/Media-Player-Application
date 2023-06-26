using MediaPlayer.src.Core.Entities;
using MediaPlayer.src.Core.Interfaces;

namespace MediaPlayer.src.Infrastructure.Data.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly Dictionary<string, List<MediaFile>> _playlists;

        public PlaylistRepository()
        {
            _playlists = new();
        }

        public bool CreatePlaylist(Playlist playlist)
        {
            if (string.IsNullOrEmpty(playlist.Name) || _playlists.ContainsKey(playlist.Name))
            {
                return false;
            }
            _playlists.Add(playlist.Name, new List<MediaFile>());
            return true;
        }

        public bool AddFileToPlaylist(string playlistName, MediaFile mediaFile)
        {
            if (string.IsNullOrEmpty(playlistName) || mediaFile == null || !_playlists.ContainsKey(playlistName))
            {
                return false;
            }
            List<MediaFile> playlist = _playlists[playlistName];
            if (playlist.Contains(mediaFile))
            {
                return false;
            }
            playlist.Add(mediaFile);
            return true;
        }

        public bool RemoveFileFromPlaylist(string playlistName, MediaFile mediaFile)
        {
            if (string.IsNullOrEmpty(playlistName) || mediaFile == null || !_playlists.ContainsKey(playlistName))
            {
                return false;
            }
            List<MediaFile> playlist = _playlists[playlistName];
            return playlist.Remove(mediaFile);
        }

        public bool RemovePlaylist(Playlist playlist)
        {
            var foundPlaylist = GetPlaylistByName(playlist.Name);
            if (foundPlaylist != null)
            {
                _playlists.Remove(playlist.Name);
                return true;
            }
            return false;
        }

        public List<MediaFile> GetPlaylistFiles(string playlistName)
        {
            if (string.IsNullOrEmpty(playlistName) || !_playlists.ContainsKey(playlistName))
            {
                return new List<MediaFile>();
            }
            return new List<MediaFile>(_playlists[playlistName]);
        }

        public List<Playlist> GetAllPlaylists()
        {
            if (_playlists.Keys.Count !> 0)
            {
                Console.WriteLine("You don't have any playlist. Create one.");
                return new List<Playlist>();
            }
            return _playlists.Select(KeyValuePair => new Playlist(KeyValuePair.Key)).ToList();
        }

        public List<MediaFile> GetPlaylistByName(string playlistName)
        {
            List<MediaFile> playlist = _playlists[playlistName];
            return playlist;
        }
    }
}