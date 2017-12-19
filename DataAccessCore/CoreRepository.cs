using DataAccessCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessCore
{
        public interface IRepository
    {
        IEnumerable<T> GetAll<T>() where T : class, IEntity;
        IEnumerable<T> GetMany<T>(Func<T, bool> predicate) where T : class, IEntity;
        T Add<T>(T newItem) where T : class, IEntity;
    }

    public class CoreRepository : IDisposable, IRepository
    {
        private readonly MaindbContext _context;

        public CoreRepository()
        {
            _context = new MaindbContext();
        }

        public IEnumerable<T> GetAll<T>() where T : class, IEntity
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> GetMany<T>(Func<T, bool> predicate) where T : class, IEntity
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public T Add<T>(T newItem) where T : class, IEntity
        {
            _context.Set<T>().Add(newItem);
            _context.SaveChanges();
            return newItem;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}