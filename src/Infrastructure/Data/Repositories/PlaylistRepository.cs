namespace MediaPlayer.src.Infrastructure.Data.Repositories
{
    public class PlaylistRepository
    {
        private readonly Dictionary<string, List<string>> _playlists;

        public PlaylistRepository()
        {
            _playlists = new Dictionary<string, List<string>>();
        }

        public bool CreatePlaylist(string playlistName)
        {
            if (string.IsNullOrEmpty(playlistName) || _playlists.ContainsKey(playlistName))
            {
                return false;
            }
            _playlists.Add(playlistName, new List<string>());
            return true;
        }

        public bool AddSongToPlaylist(string playlistName, string songFilePath)
        {
            if (string.IsNullOrEmpty(playlistName) || string.IsNullOrEmpty(songFilePath) || !_playlists.ContainsKey(playlistName))
            {
                return false;
            }
            List<string> playlist = _playlists[playlistName];
            if (playlist.Contains(songFilePath))
            {
                return false;
            }
            playlist.Add(songFilePath);
            return true;
        }

        public bool RemoveSongFromPlaylist(string playlistName, string songFilePath)
        {
            if (string.IsNullOrEmpty(playlistName) || string.IsNullOrEmpty(songFilePath) || !_playlists.ContainsKey(playlistName))
            {
                return false;
            }
            List<string> playlist = _playlists[playlistName];
            return playlist.Remove(songFilePath);
        }

        public List<string> GetPlaylistSongs(string playlistName)
        {
            if (string.IsNullOrEmpty(playlistName) || !_playlists.ContainsKey(playlistName))
            {
                return new List<string>();
            }
            return new List<string>(_playlists[playlistName]);
        }

        public List<string> GetAllPlaylists()
        {
            if (_playlists.Keys.Count !> 0)
            {
                Console.WriteLine("You don't have any playlist. Create one.");
                return new List<string>();
            }
            return _playlists.Keys.ToList();
        }
    }
}