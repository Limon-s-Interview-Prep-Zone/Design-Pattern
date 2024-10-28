using CommandPattern.Services;

namespace CommandPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OrderSystem.DriverMethod();
            FactoryNotificationSystem.DriverMethod();
        }
    }
}