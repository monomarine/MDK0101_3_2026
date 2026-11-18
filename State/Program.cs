namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.Cancel();
            order.Send();

        }
    }
}
