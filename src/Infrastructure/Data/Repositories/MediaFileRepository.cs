using MediaPlayer.src.Core.Entities;
using MediaPlayer.src.Core.Interfaces;

namespace MediaPlayer.src.Infrastructure.Data.Repositories
{
    public class MediaFileRepository : IMediaFileRepository
    {
        private static MediaFileRepository? _instance;
        private static readonly object _lockObject = new object();
        private readonly HashSet<MediaFile> _mediaFiles;

        private MediaFileRepository()
        {
           _mediaFiles = new HashSet<MediaFile>();
        }

        public static MediaFileRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        _instance ??= new MediaFileRepository();
                    }
                }
                return _instance;
            }
        }

        public bool AddMediaFile(MediaFile mediaFile)
        {
            if (mediaFile == null)
            {
                return false;
            }
            lock (_lockObject)
            {
                if (_mediaFiles.Any(file => file.Equals(mediaFile)))
                {
                    return false;
                }
                return _mediaFiles.Add(mediaFile);
            }
        }

        public bool RemoveMediaFile(MediaFile mediaFile)
        {
            if (mediaFile != null)
            {
                MediaFile? foundFile = GetMediaFileById(mediaFile.Id);
                if (foundFile != null)
                {
                    lock (_lockObject)
                    {
                        return _mediaFiles.Remove(foundFile);
                    }
                }
            }
            return false;
        }

        public IEnumerable<MediaFile> GetAllMediaFiles()
        {
            lock (_lockObject)
            {
                return _mediaFiles.ToList();
            }
        }
        
        public MediaFile? GetMediaFileById(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            MediaFile? mediaFile = _mediaFiles.FirstOrDefault(file => file.Id == id);
            if (mediaFile == null)
            {
                return null;
            }
            return mediaFile;
        }
    }
}