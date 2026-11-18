using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsCar
{
    internal class Car
    {
        private double _maxSpeed;
        private double _currentSpeed = 0;
        public event Action<double, string> SpeedElevation;
        public string GosNomer { get; }
        public Car(string gosNomer)
        {
            GosNomer = gosNomer;
        }
        public void SetMaxSpeed(double sp) => _maxSpeed = sp;
#pragma warning disable
        public void Drive()
        {
            
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"{GosNomer} - текущая скорость - {_currentSpeed}");
                    _currentSpeed += 5.7;

                    if (_currentSpeed >= _maxSpeed)
                        SpeedElevation?.Invoke(_currentSpeed, GosNomer);
                }
           
        }
    }
}
