namespace MediaPlayer.src.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MediaPlayerTypeAttribute : Attribute
    {
        public string MediaType { get; }

        public MediaPlayerTypeAttribute(string mediaType)
        {
            MediaType = mediaType;
        }
    }
}