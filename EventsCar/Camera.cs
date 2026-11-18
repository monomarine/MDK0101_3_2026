namespace EventsCar
{
    internal class Camera
    {
        private List<Car> _cars = new();
        private double _maxSpeed;

        public Camera(double maxSpeed) => _maxSpeed = maxSpeed;

        public void SuscribeCar(Car car)
        {
            _cars.Add(car); //добавление машины
            car.SetMaxSpeed(_maxSpeed);

            car.SpeedElevation += (carSpeed, nomer) => //подписка на событие
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Зарегестрировано превышение скорости на {_maxSpeed - carSpeed} км/ч {nomer}");
                Console.ResetColor();
            };
        }
    }
}
