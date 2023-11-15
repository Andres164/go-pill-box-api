namespace GoPillBox.Services
{
    public class LoggingService : ILoggingService
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("An Exception ocurred: " + exception.Message);
        }
    }
}
