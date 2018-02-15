using BeautySalon.BotEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Common
{
    public class ObjectsStoreBase<T> : IObjectsStore<T>
    {
        private List<T> _objects;

        public IEnumerable<T> Objects => _objects;

        public void RegisterCommand(T obj)
        {
            if(_objects.Contains(obj))
            {
                throw new InvalidOperationException("Object is already registered");
            }

            _objects.Add(obj);
        }

        public void Unregister(T obj)
        {
            if(!_objects.Contains(obj))
            {
                throw new InvalidOperationException("Object is not registered");
            }

            _objects.Remove(obj);
        }
    }
}
