namespace FacadePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new OrderFacade().PlaceOrder("Sifi", "7777-8888-5555-44444", 588);
        }
    }
}