using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitoring
{
    public class TemperatireChangedEventArgs : EventArgs
    {
        public double OldValue { get; }
        public double NewValue { get; }
        public TemperatireChangedEventArgs(double old, double neww) =>
            (OldValue, NewValue) = (old, neww);
    }

    internal class Termostat
    {
        private double _temperature;
        public event EventHandler<TemperatireChangedEventArgs>? TemperatureChanged;

        public double Temperature
        {
            get => _temperature;
            set
            {
                if (Math.Abs(_temperature - value) < 0.01) return;
                double oldTemp = _temperature;
                _temperature = value;
                TemperatureChanged?.Invoke(this, new TemperatireChangedEventArgs(oldTemp, value));
            }
        }

    }
}
