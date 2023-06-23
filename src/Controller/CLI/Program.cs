using MediaPlayer.src.Controller.CLI;

internal class Program
{
    private static void Main(string[] args)
    {
        MediaPlayerCLI cli = new MediaPlayerCLI();
        cli.Run();
    }
}