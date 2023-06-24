namespace MediaPlayer.src.Presentation.Loggings
{
    public class ErrorHandler
    {
        public static void HandleError(Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}