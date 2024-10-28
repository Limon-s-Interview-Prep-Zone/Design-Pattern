using ObserverDesignPattern.Services;

namespace ObserverDesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ProductNotificationSystem.DriverMethod();
            // SportsNewsPublisherFactory.DriverCode();
            NewsPublishSystemWithGenericObserverPattern.DriverCode();
        }
    }
}