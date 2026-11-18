using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    /// <summary>
    /// неизменяемый класс для хранения снимка состояния персонажа
    /// </summary>
    internal class CharacterMemento
    {
        public int health { get; }
        public int mana { get; }
        public (int, int) point { get; }

        public CharacterMemento(int h, int m, (int,int) p)
        {
            health = h;
            mana = m;
            point = p;
        }
    }
}
