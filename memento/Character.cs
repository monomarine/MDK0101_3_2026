using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    /// <summary>
    /// originator - класс, хранящий и восстанавливающий состояние
    /// </summary>
    internal class Character
    {
        private int _health;
        private int _mana;
        private (int, int) _position;
        private readonly Caretacker _caretacker;

        public Character(int health, int mana, (int,int) point)
        {
            _health = health;
            _mana = mana;
            _position = point;
            _caretacker = new Caretacker();

        }

        public void takeDamage(int damage)
        {
            _health = Math.Clamp(_health - damage, 0, 100);
        }
        public void UseMana(int mana)
        {
            _mana = Math.Clamp(_mana - mana, 0, 100);
        }
        public void MoveTo((int, int) delta)
        {
            _position = delta;
        }

        /// <summary>
        /// создание снимка
        /// </summary>
        /// <returns></returns>
        public void Save()
        {
            Console.WriteLine("состояние персонажа сохранено");
            _caretacker.Save(new CharacterMemento(_health, _mana, _position));
        }

        /// <summary>
        /// восстановление состояния из снимка
        /// </summary>
        /// <param name="memento"></param>
        public void Load()
        {
            var memento = _caretacker.Load();
            _health = memento.health;
            _mana = memento.mana;
            _position = memento.point;
            Console.WriteLine("состояние персонажа восстановлено");
        }

        public override string ToString()
        {
            return $"\nкоординаты: {_position}\n" +
                $"здоровье - {_health}\n" +
                $"мана - {_mana}\n";
        }

        internal class Caretacker
        {
            private readonly Stack<CharacterMemento> _saves = new();
            public void Save(CharacterMemento m) => _saves.Push(m);
            public CharacterMemento Load()
            {
                if (_saves.Count > 0)
                    return _saves.Pop();

                else
                    return null;
            }
        }
    }
}
