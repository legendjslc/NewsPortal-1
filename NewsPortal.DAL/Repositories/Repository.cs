using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsPortal.DAL.EF;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.DAL.Repositories
{
    class Repository<T> : IRepository<T> where T : class
    {
        private NewsPortalContext _db;

        public Repository(NewsPortalContext context)
        {
            _db = context;
        }

        public IEnumerable<T> All()
        {
            return _db.Set<T>().AsEnumerable();
        }

        public T Get(params object[] key)
        {
            return _db.Set<T>().Find(key);
        }

        public IEnumerable<T> FindAll(Func<T, bool> predicate)
        {
            return _db.Set<T>().Where(predicate).AsEnumerable();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _db.Set<T>().Where(predicate).AsEnumerable();
        }

        public T SingleOrDefault(Func<T, bool> predicate)
        {
            return _db.Set<T>().SingleOrDefault(predicate);
        }

        public T Create(T item)
        {
            return _db.Set<T>().Add(item);
        }

        public T Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
            return item;
        }

        public T Delete(params object[] key)
        {
            T item = Get(key);

            if (item != null)
                return _db.Set<T>().Remove(item);
            else
                return null;
        }
    }
}
