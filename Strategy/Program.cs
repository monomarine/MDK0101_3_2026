namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тариф: \n" +
                "1 - эконом\n" +
                "2 - бизнес\n" +
                "3 - доставка\n");
            var tarif = Convert.ToInt32(Console.ReadLine());
            IPaymentStrategy strategy = new EconomStrategy();
            switch (tarif)
            {
                case 1:
                    strategy = new EconomStrategy();
                    break;
                case 2:
                    strategy = new BussinesStrategy();
                    break;
                case 3:
                    strategy = new DostStrategy();
                    break;
                default:
                    Console.WriteLine("Выберите правильно!");
                    break;
            }
            Taxi taxi = new Taxi(strategy);

            Console.WriteLine("Введите расстояние");
            var path = Convert.ToInt32(Console.ReadLine());
            var price = taxi.Calculate(path);
            Console.WriteLine(strategy);
            Console.WriteLine("Цена за такси:" + price);


        }
    }
}
