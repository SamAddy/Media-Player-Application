namespace MediaPlayer.src.Core.Entities
{
    public class Playlist : BaseEntity
    {
        public string Name { get; private set; }
        public HashSet<MediaFile> MediaFiles;

        public Playlist(string name)
        {
            Name = name;
            MediaFiles = new HashSet<MediaFile>();
        }
    }
}