namespace Decorator_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder comp = new Computer();

            comp = new KurierDecorator(comp);

            Console.WriteLine(comp.GetDescroption());
            Console.WriteLine(comp.GetPrice());
        }
    }
}
