using System;
using System.Collections.Generic;
using System.Text;

namespace MDK0101_3_2026
{
    internal class Counter
    {
        private readonly List<Action<int>> _subscribers = new(); //список подписанных объектов
        private int _value = 0;

        public void Subscribe(Action<int> handler) => _subscribers.Add(handler);
        public void UnSubscribe(Action<int> handler) => _subscribers.Remove(handler);

        public void Work()
        {
            _value += 100;
            foreach (var s in _subscribers)
                s(_value);
        }

    }
}
