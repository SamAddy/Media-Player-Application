using System.Reflection;
using MediaPlayer.src.Core.Attributes;
using MediaPlayer.src.Core.Interfaces;
using MediaPlayer.src.Shared;

namespace MediaPlayer.src.Core.Factory
{
    public class MediaPlayerFactory
    {
        public IPlaybackService? CreateMediaPlayer(string mediaType)
        {
            try
            {
                var playbackServices = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IPlaybackService)))
                .Where(t => t.GetCustomAttribute<MediaPlayerTypeAttribute>()?.MediaType == mediaType)
                .ToList();
            
            if (playbackServices.Count == 0)
            {
                throw new NotSupportedException($"No playback service found for media type '{mediaType}'.");
            }

            var playbackServiceType = playbackServices.First();
            return (IPlaybackService)Activator.CreateInstance(playbackServiceType);
            }
            catch (NotSupportedException ex)
            {
                ErrorHandler.HandleError(ex);
                return null;
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
                return null;
            }
        }
    }
}