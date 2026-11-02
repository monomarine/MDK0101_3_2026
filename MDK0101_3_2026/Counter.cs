using System;
using System.Collections.Generic;
using System.Text;

namespace MDK0101_3_2026
{
    internal class Counter
    {
        private readonly List<Action<int>> _subscribers = new();
        private int Value = 0;

        public void Subscribe(Action<int> handler) => _subscribers.Add(handler);
        public void UnSubscribe(Action<int> handler) => _subscribers.Remove(handler);

        public void Work()
        {
            Value += 100;
            foreach (var s in _subscribers) s(Value);
        }
    }
}
