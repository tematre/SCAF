using BeautySalon.BotEngine.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.UniqObjects
{
    public class UniqObjectPool : IUniqObjectPool
    {
        private List<IUniqObject> _objects;

        public UniqObjectPool()
        {
        }

        public void Add(IUniqObject obj)
        {
            _objects.Add(obj);
        }

        public void Attach(IUniqObject obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUniqObject> GetObjects()
        {
            return _objects;
        }

        public void Remove(IUniqObject obj)
        {
            _objects.Remove(obj);
        }

        public void Restore()
        {
            throw new NotImplementedException();
        }

        public void SaveObjects()
        {
            throw new NotImplementedException();
        }
    }
}
