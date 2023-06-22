namespace MediaPlayer.src.Core.Entities
{
    public abstract class MediaFile : BaseEntity
    {
        public string? FileName { get; private set; }
        public string? FilePath { get; set; }    
        public TimeSpan Duration { get; set; }
    }
}