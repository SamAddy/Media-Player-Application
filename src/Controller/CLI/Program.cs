using MediaPlayer.src.Controller.CLI;
using MediaPlayer.src.Controller.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        MediaPlayerCLI cli = new MediaPlayerCLI();
        cli.Run();
    }
}