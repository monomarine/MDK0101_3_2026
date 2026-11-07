namespace OventOnLimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TiketSaler saler = new TiketSaler();
            bool isPossibleSale = true;

            saler.ReachLimit += (obj, e) => //подписка на событие через лямбда метожд
            {
                isPossibleSale = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("все билеты проданы");
                Console.WriteLine("всего продано "+ e.TicketCount);
                Console.ResetColor();
                
            };

            while(isPossibleSale)
            {
                Console.WriteLine("продан билет");
                saler.SaleTiket();
            }
        }
    }
}
