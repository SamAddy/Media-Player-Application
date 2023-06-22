namespace MediaPlayer.src.Core.Entities
{
    public class Playlist
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private HashSet<MediaFile> _mediaFiles;

        public Playlist(string name)
        {
            Name = name;
            _mediaFiles = new HashSet<MediaFile>();
        }

        
        public void AddMediaFile(MediaFile mediaFile)
        {
            
        }
    }
}