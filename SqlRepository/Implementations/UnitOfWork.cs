using Microsoft.EntityFrameworkCore;
using NorthWIndDatabase.Models;
using SqlRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRepository.Implementations
{
    internal class UnitOfWork :IDisposable
    {
        private Dictionary<Type, object> repositories;


        public UnitOfWork(DbContext context)
        {
            this.Context = context;
        }
        public DbContext Context { get; }

        public IRepository<Product> Products
        {
            get { return GetRepository<Product>(); }
        }
        public IRepository<Category> Categories
        {
            get { return GetRepository<Category>(); }
        }


        private bool disposed = false;
        public void DetachAll()
        {
            foreach (var dbEntityEntry in this.Context.ChangeTracker.Entries().ToList())
            {
                if (dbEntityEntry.Entity != null)
                {
                    dbEntityEntry.State = EntityState.Detached;
                }
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private IRepository<T> GetRepository<T>() where T :class
        {
            if (repositories==null)
            {
                repositories = new Dictionary<Type, object>();
            }
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(Repository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.Context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
