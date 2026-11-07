using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    public record UserLoggedId(string Name);
    public record OrderComplete(int OrderId);

    /// <summary>
    /// шина событий - клас содержащий все событий от разных издателей
    /// подписчики подписываются не на издателя а на тип события
    /// </summary>
    internal class EventBus
    {
        private readonly Dictionary<Type, List<Delegate>> _handlers = new(); //место хранения всех событий
    
        public IDisposable Subscribe<T>(Action<T> handler)
        {
            var type = typeof(T);
            if(_handlers.TryGetValue(type, out var list))
            {
                list.Add(handler);
            }
            
                _handlers[type] = list = new List<Delegate>();
                list.Add(handler);


            //todo
            return new Subcription(() =>
                {
                    list.Remove(handler);
                    if (list.Count == 0)
                        _handlers.Remove(type);
                }
            );

        }

        public void Publish<T>(T message)
        {
            if (!_handlers.TryGetValue(typeof(T), out var list)) return;
            foreach(var item in list)
            {
                ((Action<T>)item).Invoke(message);
            }
        }
    
    
    }
}
