namespace TemperatureMonitoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Termostat termostat = new Termostat();
            List<string> log = new();

            void Logger(Object obj, TemperatireChangedEventArgs e)
            {
                log.Add($"{DateTime.Now}:\t{e.OldValue} -> {e.NewValue}");
            }

            //множественная подписка на одно событие
            termostat.TemperatureChanged += Logger;
            termostat.TemperatureChanged += Display;
            termostat.TemperatureChanged += Alarm;

            for(int i = 0; i < 100; i++)
            {
                int d = new Random().Next(-10, 11);
                termostat.Temperature = Math.Clamp(termostat.Temperature + d, -40, 40);
            }

            Console.WriteLine("\n Содержимое лога");
            foreach (var item in log)
            {
                Console.WriteLine(item);
            }

        }

        public static void Display(Object obj, TemperatireChangedEventArgs e )
        {
            Console.WriteLine($"текущая температура {e.NewValue} градусов Цельсия");
        }
        public static void Alarm(Object obj, TemperatireChangedEventArgs e)
        {
            if (e.NewValue > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ЖАРА");
                Console.ResetColor();
            }
            else if(e.NewValue < -20)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("МОРОЗ");
                Console.ResetColor();
            }
            if( Math.Abs(e.NewValue - e.OldValue) >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("РЕЗКОЕ ИЗМЕНЕНИЕ ТЕМПЕРАТУРЫ");
                Console.ResetColor();
            }
        }

    }
}
