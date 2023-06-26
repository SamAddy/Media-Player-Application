using MediaPlayer.src.Core.Entities;

namespace MediaPlayer.src.Core.Interfaces
{
    public interface IMediaFileRepository
    {
        MediaFile? GetMediaFileById(int id);
        bool AddMediaFile(MediaFile mediaFile);
        bool RemoveMediaFile(MediaFile mediaFile);
        IEnumerable<MediaFile> GetAllMediaFiles();
    }
}