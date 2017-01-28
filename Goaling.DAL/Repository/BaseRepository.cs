using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Goaling.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        int Save();
        void Update(T entity);
    }

    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private DbSet<T> dbSet;
        private GoalingEntities db;
        
        public BaseRepository(GoalingEntities db, DbSet<T> dbSet)
        {
            this.dbSet = dbSet;
            this.db = db;
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            throw new NotImplementedException($"Update method is not defined for {this.GetType()}.");
        }

    }
}
