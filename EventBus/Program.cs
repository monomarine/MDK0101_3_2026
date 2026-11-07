namespace EventBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventBus bus = new EventBus();

            using var sub1 = bus.Subscribe<UserLoggedId>(m =>
                Console.WriteLine($"Авторизация - {m.Name}"));

            using var sub2 = bus.Subscribe<OrderComplete>(m =>
                Console.WriteLine($"оформлен заказ {m.OrderId}"));

            bus.Publish(new UserLoggedId("admin"));
            bus.Publish(new UserLoggedId("user232332523"));
            bus.Publish(new OrderComplete(58746));
            bus.Publish(new OrderComplete(3765));
        }
    }
}
