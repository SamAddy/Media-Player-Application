using MediaPlayer.src.Core.Services;

namespace MediaPlayer.src.Controller.CLI
{
    public class MediaPlayerCLI
    {
        private readonly AudioPlaybackService _audioPlaybackService;
        private readonly VideoPlaybackService _videoPlaybackService;
        private readonly PlaylistService _playlistService;
        private bool _isVideoPlayerSelected;

        public MediaPlayerCLI()
        {
            _audioPlaybackService = new AudioPlaybackService();
            _videoPlaybackService = new VideoPlaybackService();
            _playlistService = new PlaylistService();
            _isVideoPlayerSelected = false;
        }

        public void Run()
        {
            Console.WriteLine("SKA Media Player");
            while (true)
            {
                DisplayMainMenu();
                string? userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        _isVideoPlayerSelected = false;
                        PlayAction();
                        break;
                    case "2":
                        _isVideoPlayerSelected = true;
                        PlayAction();
                        break;
                    case "3":
                        PauseAction();
                        break;
                    case "4":
                        StopAction();
                        break;
                    case "5":
                        break;
                    case "6":
                        CreatePlaylistAction();
                        break;
                    case "7":
                        AddFileToPlaylist();
                        break;
                    case "8":
                        RemoveMediaFromPlaylistAction();
                        break;
                    case "0":
                        Console.WriteLine("Thank you for using SKA Media Player.");
                        return;
                    default: 
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1. Play Music");
            Console.WriteLine("2. Play Video");
            Console.WriteLine("3. Pause");
            Console.WriteLine("4. Stop");
            Console.WriteLine("5. Seek");
            Console.WriteLine("6. Create Playlist");
            Console.WriteLine("7. Add file to Playlist");
            Console.WriteLine("8. Remove file from Playlist");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
        }

        private void PlayAction()
        {
            Console.Write("Enter the file path: ");
            string? filePath = Console.ReadLine();
            if (filePath != null)
            {
                if (_isVideoPlayerSelected)
                {
                    _videoPlaybackService.Play();
                }
                else
                {
                    _audioPlaybackService.Play();
                }
            }
        }

        private void PauseAction()
        {
            if (_isVideoPlayerSelected)
            {
                _videoPlaybackService.Pause();
            }
            else
            {
                _audioPlaybackService.Pause();
            }
        }

        private void StopAction()
        {
            if (_isVideoPlayerSelected)
            {
                _videoPlaybackService.Stop();
            }
            else
            {
                _audioPlaybackService.Stop();
            }
        }

        private void CreatePlaylistAction()
        {
            Console.Write("Enter the playlist name: ");
            string? playlistName = Console.ReadLine();
            if (playlistName != null)
            {
                _playlistService.CreatePlaylist(playlistName);
            }
        }

        private void AddFileToPlaylist()
        {
            Console.Write("Enter the playlist name: ");
            string? playlistName = Console.ReadLine();
            Console.Write("Enter song name: ");
            string? fileName = Console.ReadLine();
            if (playlistName != null && fileName != null)
            {
                _playlistService.AddMediaToPlaylist(playlistName, fileName);
            }
        }

        private void RemoveMediaFromPlaylistAction()
        {
            Console.Write("Enter the playlist name: ");
            string? playlistToRemoveFrom = Console.ReadLine();
            Console.Write("Enter the song title to remove: ");
            string? mediaToRemove = Console.ReadLine();
            if (playlistToRemoveFrom != null && mediaToRemove != null)
            {
                _playlistService.RemoveMediaFromPlaylist(playlistToRemoveFrom.ToString(), mediaToRemove.ToString());
            }
        }
    }
}